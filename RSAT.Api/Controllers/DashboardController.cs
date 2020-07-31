using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using NovusConsulting.Data;
using RSAT.Api.Data.Entities;
using RSAT.Api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq.Dynamic.Core;
using NPOI.SS.Formula.Functions;

namespace RSAT.Api.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class DashboardController : RSAT.Api.Controllers.BaseController
    {
        public DashboardController(IApplicationLifetime applicationLifetime, IMemoryCache memoryCache, IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer) : base(applicationLifetime, memoryCache, configuration, dataLayer, etlLayer) { }

        public IActionResult Index()
        {
            using (var context = new RSAT.Api.Data.Proxy.ATT2018NOVUSContext())
            {
                var baseViewModel = base.GetLayoutViewModel();
                var viewModel = new HomeViewModel()
                {
                    User = baseViewModel.User,
                    RoleCollection = baseViewModel.RoleCollection,
                    TableCollection = baseViewModel.TableCollection,
                    //Olap = baseViewModel.Olap,
                    //Localization = baseViewModel.Localization,
                    EmployeeCollection = (from userinfo in context.Userinfo
                                          join department in context.Dept on userinfo.Deptid equals department.Deptid
                                          select new Employee()
                                          {
                                              Id = userinfo.Userid,
                                              Name = userinfo.Name,
                                              Picture = userinfo.Picture,
                                              Department = department.DeptName,
                                              CardNumber = userinfo.CardNum,
                                              Status = userinfo.UserFlag.ToString(),
                                              ActualCheckinStatuse = (from checkinout in context.Checkinout
                                                                      join status in context.Status on checkinout.CheckType equals status.Statusid
                                                                      where checkinout.Userid == userinfo.Userid
                                                                      orderby checkinout.CheckTime descending
                                                                      select new Checkinout
                                                                      {
                                                                          CheckStatus = status.StatusText,
                                                                          CheckTime = checkinout.CheckTime
                                                                      }).FirstOrDefault(),
                                              HistoryOfStatuses = (from checkinout in context.Checkinout
                                                                   join status in context.Status on checkinout.CheckType equals status.Statusid
                                                                   where checkinout.Userid == userinfo.Userid
                                                                   orderby checkinout.CheckTime descending
                                                                   select new Checkinout
                                                                   {
                                                                       CheckStatus = status.StatusText,
                                                                       CheckTime = checkinout.CheckTime
                                                                   }).ToList(),

                                          }).ToList()
                };
                return View(viewModel);
            }
        }
        [HttpPost]
        public IActionResult Status()
        {
            List<Employee> emp = new List<Employee>();

            using (var context = new RSAT.Api.Data.Proxy.ATT2018NOVUSContext())
            {
                var baseViewModel = base.GetLayoutViewModel();
                var viewModel = new HomeViewModel()
                {
                    EmployeeCollection = (from userinfo in context.Userinfo
                                          join department in context.Dept on
                                          userinfo.Deptid equals department.Deptid
                                          select new Employee()
                                          {
                                              Id = userinfo.Userid,
                                              Name = userinfo.Name,
                                              Picture = userinfo.Picture,
                                              Department = department.DeptName,
                                              Status = userinfo.UserFlag.ToString(),
                                              ActualCheckinStatuse = (from checkinout in context.Checkinout
                                                                      join status in context.Status on checkinout.CheckType equals status.Statusid
                                                                      where checkinout.Userid == userinfo.Userid
                                                                      orderby checkinout.CheckTime descending
                                                                      select new Checkinout
                                                                      {
                                                                          CheckStatus = status.StatusText,
                                                                          CheckTime = checkinout.CheckTime
                                                                      }).FirstOrDefault(),
                                              HistoryOfStatuses = (from checkinout in context.Checkinout
                                                                   join status in context.Status on checkinout.CheckType equals status.Statusid
                                                                   where checkinout.Userid == userinfo.Userid
                                                                   orderby checkinout.CheckTime descending
                                                                   select new Checkinout
                                                                   {
                                                                       CheckStatus = status.StatusText,
                                                                       CheckTime = checkinout.CheckTime
                                                                   }).ToList(),


                                          }).ToList(),


                };
               
                foreach (var item in viewModel.EmployeeCollection)
                {

                    Employee em = new Employee();

                    em.Id = item.Id;

                    var stat = (
                        from userinfo in context.Userinfo
                        from checkinout in context.Checkinout
                        join status in context.Status on checkinout.CheckType equals status.Statusid
                        where checkinout.Userid == item.Id
                        orderby checkinout.CheckTime descending
                        select new Checkinout
                        {
                            CheckStatus = status.StatusText,
                            CheckTime = checkinout.CheckTime
                        }).ToList();
 
                    em.Name = item.Name;
                    em.Department = item.Department;
                    em.ActualCheckinStatuse = new Checkinout();

                    foreach (var z in stat)
                    {
                        em.ActualCheckinStatuse.CheckStatus = z.CheckStatus;
                    }

                    emp.Add(em);

                }

                
            }
            var Total = emp.Count();
            return Json(new { recordsFiltered = Total, recordsTotal = Total, data = emp });
        }
        public class HoursPerDay
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public int WorkingMinutes { get; set; }
            public string WorkingHours { get; set; }
            public DateTime Date { get; set; }

        }




        [HttpPost]
        public IActionResult WorkingHours()
        {
            List<HoursPerDay> h = new List<HoursPerDay>();
            List<HoursPerDay> Result = new List<HoursPerDay>();

            int pageSize = 10;

            var start = Request.Form["start"].FirstOrDefault();

            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

            int skip = start != null ? Convert.ToInt32(start) : 0;

            using (var context = new RSAT.Api.Data.Proxy.ATT2018NOVUSContext())
            {

                var Rez = (from userinfo in context.Userinfo
                           join Checkinout in context.Checkinout on userinfo.Userid equals Checkinout.Userid
                           where Checkinout.CheckType == 0
                           select new HoursPerDay
                           {
                               UserId = userinfo.Userid,
                               Name = userinfo.Name,
                               Date = Checkinout.CheckTime
                           }).ToList();

                var In = (from userinfo in context.Userinfo
                          join Checkinout in context.Checkinout on userinfo.Userid equals Checkinout.Userid
                          where Checkinout.CheckType == 0
                          select new HoursPerDay
                          {
                              UserId = userinfo.Userid,
                              Name = userinfo.Name,
                              Date = Checkinout.CheckTime
                          }).Skip(skip).Take(pageSize).ToList();

                //var Out = (from userinfo in context.Userinfo
                //          join Checkinout in context.Checkinout on userinfo.Userid equals Checkinout.Userid
                //          where Checkinout.CheckType == 3
                //          orderby Checkinout.CheckTime descending
                //          select new HoursPerDay
                //          {
                //              UserId = userinfo.Userid,
                //              Name = userinfo.Name,
                //              Date = Checkinout.CheckTime
                //          }).Skip(skip).Take(pageSize).ToList();

                foreach (var i in In)
                {
                    var T = (from userinfo in context.Userinfo
                             join Checkinout in context.Checkinout on userinfo.Userid equals Checkinout.Userid
                             where Checkinout.CheckType == 3 && Checkinout.Userid == i.UserId && Checkinout.CheckTime.Year == i.Date.Year && Checkinout.CheckTime.Month == i.Date.Month && Checkinout.CheckTime.Day == i.Date.Day

                             select new HoursPerDay
                             {
                                 UserId = userinfo.Userid,
                                 Name = userinfo.Name,
                                 Date = Checkinout.CheckTime
                             }).ToList();

                    HoursPerDay hpd = new HoursPerDay();
                    hpd.UserId = i.UserId;
                    hpd.Name = i.Name;
                    hpd.Date = i.Date;

                    if (T != null && T.FirstOrDefault() != null)
                    {
                        hpd.WorkingMinutes = CompareDate(i.Date, T.FirstOrDefault().Date);

                    }
                    h.Add(hpd);
                }


                List<HoursPerDay> b = new List<HoursPerDay>();

                foreach (var B in h)
                {

                    var BF = (from userinfo in context.Userinfo
                              join Checkinout in context.Checkinout on userinfo.Userid equals Checkinout.Userid
                              where Checkinout.CheckType == 2 && Checkinout.Userid == B.UserId && Checkinout.CheckTime.Year == B.Date.Year && Checkinout.CheckTime.Month == B.Date.Month && Checkinout.CheckTime.Day == B.Date.Day
                              select new HoursPerDay
                              {
                                  UserId = userinfo.Userid,
                                  Name = userinfo.Name,
                                  Date = Checkinout.CheckTime
                              }).FirstOrDefault();

                    var BL = (from userinfo in context.Userinfo
                              join Checkinout in context.Checkinout on userinfo.Userid equals Checkinout.Userid
                              where Checkinout.CheckType == 2 && Checkinout.Userid == B.UserId && Checkinout.CheckTime.Year == B.Date.Year && Checkinout.CheckTime.Month == B.Date.Month && Checkinout.CheckTime.Day == B.Date.Day
                              select new HoursPerDay
                              {
                                  UserId = userinfo.Userid,
                                  Name = userinfo.Name,
                                  Date = Checkinout.CheckTime
                              }).LastOrDefault();


                    HoursPerDay hpd = new HoursPerDay();
                    hpd.UserId = B.UserId;
                    hpd.Name = B.Name;
                    hpd.Date = B.Date;


                    if (BF != null && BL != null)
                    {

                        hpd.WorkingMinutes = CompareDate(BF.Date, BL.Date);

                    }

                    b.Add(hpd);
                }


                foreach (var hours in h)
                {
                    var Break = b.Where(o => o.UserId == hours.UserId && o.Date.Year == hours.Date.Year && o.Date.Month == hours.Date.Month && o.Date.Day == hours.Date.Day);

                    HoursPerDay Res = new HoursPerDay();
                    if (Break != null && Break.Any())
                    {
                        var resu = hours.WorkingMinutes - Break.FirstOrDefault().WorkingMinutes;

                        var total = "";

                        var hour = resu / 60;
                        var Min = resu % 60;

                        if (hour < 0 || Min < 0)
                        {
                            Min = 0;
                            hour = 0;
                            string mesazhi = "  (Ka pasur gabim ne kalkulim)";
                            total = hour + ":" + Min;

                            Res.UserId = hours.UserId;
                            Res.Name = hours.Name;
                            Res.Date = hours.Date;
                            Res.WorkingHours = total + mesazhi;

                        }

                        else
                        {
                            total = hour + ":" + Min;
                            Res.UserId = hours.UserId;
                            Res.Name = hours.Name;
                            Res.Date = hours.Date;
                            Res.WorkingHours = total;
                        }
                    }
                    else
                    {
                        var hour = hours.WorkingMinutes / 60;
                        var Min = hours.WorkingMinutes % 60;

                        var total = "";

                        if (hour < 0 || Min < 0)
                        {
                            Min = 0;
                            hour = 0;
                            string mesazhi = "  (Ka pasur gabim ne kalkulim)";
                            total = hour + ":" + Min;

                            Res.UserId = hours.UserId;
                            Res.Name = hours.Name;
                            Res.Date = hours.Date;
                            Res.WorkingHours = total + mesazhi;

                        }

                        else
                        {
                            total = hour + ":" + Min;

                            Res.UserId = hours.UserId;
                            Res.Name = hours.Name;
                            Res.Date = hours.Date;
                            Res.WorkingHours = total + " (Nuk ka Deklaruar Pauze)";
                        }

                    }
                    Result.Add(Res);


                }



                int TotalRecord = Rez.Count();

                int totalPage = (int)Math.Ceiling((decimal)TotalRecord / (decimal)pageSize);



                var query = Result.OrderBy(a => a.Date).ToList();

                return Json(new { draw = draw, recordsFiltered = TotalRecord, recordsTotal = TotalRecord, data = query });

            }



        }

        public int CompareDate(DateTime inTime, DateTime outTime)
        {


            var Inhours = Convert.ToInt32(inTime.ToString("HH"));

            var Inminute = Convert.ToInt32(inTime.ToString("mm"));

            var totalmin = Inhours * 60 + Inminute;


            var Outhours = Convert.ToInt32(outTime.ToString("HH"));

            var Outminute = Convert.ToInt32(outTime.ToString("mm"));

            var totalminout = Outhours * 60 + Outminute;

            var total = totalminout - totalmin;


            return total;
        }

    }



}
