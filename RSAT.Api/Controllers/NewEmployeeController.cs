using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using NovusConsulting.Data;
using NovusConsulting.Data.Models;
using RSAT.Api.Data.Entities;
using RSAT.Api.Data.ViewModels;

namespace RSAT.Api.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class NewEmployeeController : RSAT.Api.Controllers.BaseController
    {
        public NewEmployeeController(IApplicationLifetime applicationLifetime, IMemoryCache memoryCache, IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer) : base(applicationLifetime, memoryCache, configuration, dataLayer, etlLayer) { }

            public IActionResult Index()
            {
                using (var context = new RSAT.Api.Data.Proxy.ATT2018NOVUSContext())
                {
                    var baseViewModel = base.GetLayoutViewModel();

                    var viewModel = new ProfileViewModel()
                    {
                        User = baseViewModel.User,
                        RoleCollection = baseViewModel.RoleCollection,
                        TableCollection = baseViewModel.TableCollection,
                        //Olap = baseViewModel.Olap,
                        //Localization = baseViewModel.Localization,

                        EmployeeCollection = (from userinfo in context.Userinfo
                                              select new Employee()
                                              {
                                                  Name = userinfo.Name,
                                                  CardNumber = userinfo.CardNum,    
                                                  Status = userinfo.UserFlag.ToString(),
                                                  ActualCheckinStatuse = (from checkinout in context.Checkinout
                                                                          join status in context.Status on checkinout.CheckType equals status.Statusid
                                                                          orderby checkinout.CheckTime descending
                                                                          select new Checkinout
                                                                          {
                                                                              CheckStatus = status.StatusText,
                                                                              CheckTime = checkinout.CheckTime,
                                                                          }).First(),
                                              }).ToList()

                    };
                    return View(viewModel);
                }
            }
        [HttpPost]
        public IActionResult Profile([FromBody] Employee model)
        {
            try
            {
                using (var context = new RSAT.Api.Data.ApplicationDbContext("Server=localhost;Database=RSAT;Trusted_Connection=True;MultipleActiveResultSets=true;"))
                {
                    var userId = base.GetUserId();
                    var user = new Employee();
                    user.CardNumber = model.CardNumber;
                    user.Department = model.Department;
                    user.CardNumber = model.CardNumber;
                    context.Employee.Add(user);
                    context.SaveChanges();
                    return StatusCode(200);
                }
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
    }
}