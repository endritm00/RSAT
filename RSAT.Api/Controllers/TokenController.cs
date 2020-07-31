using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using NovusConsulting.Api;
using NovusConsulting.Data;
using NovusConsulting.Data.Models;
using System;

namespace RSAT.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Area("v1")]
    public class TokenController : BaseTokenController
    {
        public TokenController( IApplicationLifetime appliciationLifetime, IMemoryCache memoryCache ,IConfiguration configuration, IDataLayer dataLayer , IEtlLayer etlLayer) : base(appliciationLifetime , memoryCache ,configuration, dataLayer, etlLayer) { }

        /// <summary>
        /// Generates a token
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Returns the generated token</response>
        /// <response code="400">If the request is not valid</response>
        /// <response code="500">If there is an internal server error</response>
        [HttpPost]
        [ProducesResponseType(typeof(LoginResponseModel), 200)]
        [ProducesResponseType(typeof(InternalServerErrorResponseModel), 500)]
        public IActionResult Post([FromBody] LoginModel model)
        {
            try
            {
                var response = base.TokenBase(model);
                return StatusCode(200, response);
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
