using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using NovusConsulting.Api;
using NovusConsulting.Data;
using NovusConsulting.Api.ViewModels;
using NovusConsulting.Data.Models;
using NovusConsulting.Data.Entities;
using NovusConsulting.Data.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;

namespace RSAT.Api.Controllers
{
    public class AccountController : BaseAccountController
    {
        public AccountController(IApplicationLifetime applicationLifetime , IMemoryCache memoryCache, IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer ) : base(applicationLifetime, memoryCache, configuration, dataLayer, etlLayer) { }
         
        public IActionResult Login()
        {
            var viewModel = new LoginViewModel();
            viewModel.Message = "";
            viewModel.Localization = _dataLayer.GetConfiguration().Localization;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var response = base.LoginBase(model);
            if (response.Success) { return RedirectToAction("Index", "Home"); }
            else
            {
                var viewModel = new LoginViewModel();
                viewModel.Message = "Invalid login attempt.";
                viewModel.Localization = _dataLayer.GetConfiguration().Localization;
                return View(viewModel);
            }
        }

        public IActionResult Unauthorized() { return View(); }
        public IActionResult InternalServerError() { return View(); }

        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult Profile() { return View(base.GetLayoutViewModel()); }

        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        [HttpPost]
        public IActionResult Profile([FromBody] ProfileModel model)
        {
            try
            {
                var userId = base.GetUserId();
                var user = _dataLayer.GetRepository<User>().GetById(userId);
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.Password = Utilities.GetSHA256(model.Password);
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

        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        [HttpPost]
        public IActionResult Logout()
        {
            base.LogoutBase();
            return RedirectToAction("Index", "Home");
        }
    }
}