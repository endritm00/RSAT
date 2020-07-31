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

namespace RSAT.Api.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class HomeController : RSAT.Api.Controllers.BaseController
    {
        public HomeController(IApplicationLifetime applicationLifetime, IMemoryCache memoryCache, IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer) : base(applicationLifetime, memoryCache, configuration, dataLayer, etlLayer) { }

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
                                                                }).FirstOrDefault()
                                            }).ToList()
                };
                return View(viewModel);
            }
        }
        public IActionResult About() { return View(base.GetLayoutViewModel()); }
        public IActionResult Contact() { return View(base.GetLayoutViewModel()); }
    }
}
