using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NovusConsulting.Data;
using NovusConsulting.Data.Models;
using RSAT.Api.Data.Entities;
using RSAT.Api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic.Core;



namespace RSAT.Api.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class ProfileController : RSAT.Api.Controllers.BaseController
    {
        public ProfileController(IApplicationLifetime applicationLifetime, IMemoryCache memoryCache, IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer) : base(applicationLifetime, memoryCache, configuration, dataLayer, etlLayer) { }
        public IActionResult Index(int? Id)
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
                                          where userinfo.Userid == Id
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

                                              TodayCheckedStatus = (from checkinout in context.Checkinout
                                                                    join status in context.Status on checkinout.CheckType equals status.Statusid
                                                                    where checkinout.Userid == userinfo.Userid
                                                                    where checkinout.CheckTime.Date == DateTime.Today.Date
                                                                    orderby checkinout.CheckTime descending
                                                                    select new Checkinout
                                                                    {
                                                                        CheckStatus = status.StatusText,
                                                                        CheckTime = checkinout.CheckTime
                                                                    }).ToList()

                                          }).ToList()
                };
                return View(viewModel);
            }

        }
        public class Task
        {

            public string Department { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }


        }
        public class HistoryOfStatuses
        {
            public string CheckStatus { get; set; }
            public DateTime CheckTime { get; set; }
        }

        [HttpPost]
        public IActionResult GetData(int id, int pageSize, int TotalRecord, int totalPage)
        {

            using (var context = new RSAT.Api.Data.Proxy.ATT2018NOVUSContext())
            {
                var histories = (from checkinout in context.Checkinout
                                 join status in context.Status on checkinout.CheckType equals status.Statusid
                                 where checkinout.Userid == id
                                 orderby checkinout.CheckTime descending
                                 select new HistoryOfStatuses
                                 {
                                     CheckStatus = status.StatusText,
                                     CheckTime = checkinout.CheckTime
                                 }).ToList();

                List<HistoryOfStatuses> data = new List<HistoryOfStatuses>();

                foreach (var i in histories)
                {
                    HistoryOfStatuses obj = new HistoryOfStatuses();

                    obj.CheckStatus = i.CheckStatus;
                    obj.CheckTime = i.CheckTime;

                    data.Add(obj);

                }



                pageSize = 10;

                TotalRecord = data.Count();

                totalPage = (int)Math.Ceiling((decimal)TotalRecord / (decimal)pageSize);

                var length = Request.Form["length"].FirstOrDefault();

                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][CheckStatus]"].FirstOrDefault();

                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                var start = Request.Form["start"].FirstOrDefault();

                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

                int skip = start != null ? Convert.ToInt32(start) : 0;

                //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                //{
                //    data = data.OrderBy(sortColumn + " " + sortColumnDirection);
                //}
                ////Search  
                //if (!string.IsNullOrEmpty(searchValue))
                //{
                //    data = data.Where(m => m.CheckTime == searchValue);

                //    data = data.Where(m => m.CheckStatus == searchValue);
                //}

                var query = data.Skip(skip).Take(pageSize).ToList();

                return Json(new { draw = draw, recordsFiltered = TotalRecord, recordsTotal = TotalRecord, data = query }); ;

            }

        }


        [HttpPost]
        public string Date(string dt)
        {
            string sJSONResponse = "";
            List<string> data = new List<string>();
            using (var context = new RSAT.Api.Data.Proxy.ATT2018NOVUSContext())
            {

                var baseViewModel = (from userinfo in context.Userinfo
                                     join department in context.Dept on userinfo.Deptid equals department.Deptid

                                     select new
                                     {
                                         Id = userinfo.Userid,
                                         Name = userinfo.Name,
                                         Department = department.DeptName,
                                         CardNumber = userinfo.CardNum,
                                         Status = userinfo.UserFlag.ToString(),
                                         HistoryOfStatuses = (from checkinout in context.Checkinout
                                                              join status in context.Status on checkinout.CheckType equals status.Statusid
                                                              where checkinout.Userid == userinfo.Userid
                                                              orderby checkinout.CheckTime descending
                                                              select new Checkinout
                                                              {
                                                                  CheckStatus = status.StatusText,
                                                                  CheckTime = checkinout.CheckTime
                                                              }).ToList(),
                                     }).ToList();

                foreach (var i in baseViewModel)
                {
                    foreach (var h in i.HistoryOfStatuses)
                    {
                        if (h.CheckTime.Equals(dt))
                        {
                            var s = "[\"" + h.CheckStatus + "\"," + "\"" + h.CheckTime + "\"]";
                            data.Add(s);
                        }
                    }

                }
                sJSONResponse = "{" + data + "}";

            }

            return sJSONResponse;
        }

        [HttpPost]
        public IActionResult Edit([FromBody] Employee model, int id)
        {
            try
            {
                var userId = base.GetUserId();
                var user = _dataLayer.GetRepository<Employee>().GetById(userId);

                user.UserId = model.Id;

                user.Name = model.Name;
                user.Department = model.Department;
                user.Picture = model.Picture;

                _dataLayer.Update(user);
                _dataLayer.SaveChanges();

                return StatusCode(200);
            }
            catch (Exception exception)
            {
                var errorResponse = new InternalServerErrorResponseModel();
                errorResponse.LogId = Guid.NewGuid().ToString();
                errorResponse.Message = exception.Message;
                errorResponse.StackTrace = exception.StackTrace;
                return StatusCode(500, errorResponse);
            }
        }
        [HttpPost]
        public IActionResult Status([FromBody] Task model)
        {

            var tsk = new Task();

            tsk.Department = model.Department;
            tsk.Description = model.Description;
            tsk.Status = model.Status;


            return StatusCode(200);
        }
        public IActionResult Education([FromBody] Employee em)
        {
            using (var context = new RSAT.Api.Data.ApplicationDbContext("Server=localhost;Database=RSAT;Trusted_Connection=True;MultipleActiveResultSets=true;"))
            {
                var user = new Employee();
                user.UDeg = em.UDeg;
                user.UName = em.UName;
                user.UField = em.UField;

                context.Employee.Update(user);
                context.SaveChanges();
                return StatusCode(200);
            }

        }
    }
}

