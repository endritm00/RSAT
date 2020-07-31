using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using NovusConsulting.Data;

namespace RSAT.Api.Controllers
{
    public class BaseController : NovusConsulting.Api.BaseController
    {
        public BaseController(IApplicationLifetime applicationLifetime, IMemoryCache memoryCache ,IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer) : base(applicationLifetime ,memoryCache ,configuration, dataLayer, etlLayer) { }

        protected IActionResult Unauthorized()
        {
            return RedirectToAction("Unauthorized", "Account");
        }
    }
}
