using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using NovusConsulting.Api;
using NovusConsulting.Data;
using NovusConsulting.Data.Models;
using RSAT.Api.Data.Entities;
using System.Collections.Generic;

namespace RSAT.Api.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme + "," + JwtBearerDefaults.AuthenticationScheme)]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Area("v1")]
    public class EmployeeController : GenericController<Employee>
    {
        public EmployeeController(IApplicationLifetime applicationLifetime, IMemoryCache memoryCache, IConfiguration configuration, IDataLayer dataLayer, IEtlLayer etlLayer) : base(applicationLifetime, memoryCache, configuration, dataLayer, etlLayer) { }

        /// <summary>
        /// POST
        /// </summary>
        /// <param name="entity"></param>
        /// <response code="200">Returns the entity</response>
        /// <response code="400">If the request is not valid</response>
        /// <response code="401">If the user is not authenticated or authorized</response>
        /// <response code="500">If there is an internal server error</response>
        [HttpPost]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(typeof(BadRequestResponseModel), 400)]
        [ProducesResponseType(typeof(void), 401)]
        [ProducesResponseType(typeof(InternalServerErrorResponseModel), 500)]
        public IActionResult Post([FromBody] Employee entity) { return base.PostBase(entity); }

        /// <summary>
        /// PUT
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <response code="200">Returns the entity</response>
        /// <response code="400">If the request is not valid</response>
        /// <response code="401">If the user is not authenticated or authorized</response>
        /// <response code="500">If there is an internal server error</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(typeof(BadRequestResponseModel), 400)]
        [ProducesResponseType(typeof(void), 401)]
        [ProducesResponseType(typeof(InternalServerErrorResponseModel), 500)]
        public IActionResult Put([FromRoute] int id, [FromBody] Employee entity)
        {
            return base.PutBase(id, entity);
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Returns the successful response</response>
        /// <response code="400">If the request is not valid</response>
        /// <response code="401">If the user is not authenticated or authorized</response>
        /// <response code="500">If there is an internal server error</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(BadRequestResponseModel), 400)]
        [ProducesResponseType(typeof(void), 401)]
        [ProducesResponseType(typeof(InternalServerErrorResponseModel), 500)]
        public IActionResult Delete([FromRoute] int id) { return base.DeleteBase(id); }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Returns the paged list of entities</response>
        /// <response code="400">If the request is not valid</response>
        /// <response code="401">If the user is not authenticated or authorized</response>
        /// <response code="500">If there is an internal server error</response>
        [HttpGet]
        [ProducesResponseType(typeof(PagedResultModel<Employee>), 200)]
        [ProducesResponseType(typeof(BadRequestResponseModel), 400)]
        [ProducesResponseType(typeof(void), 401)]
        [ProducesResponseType(typeof(InternalServerErrorResponseModel), 500)]
        public IActionResult Get([FromQuery] GetModel model) { return base.GetBase(model); }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields"></param>
        /// <response code="200">Returns the entity</response>
        /// <response code="400">If the request is not valid</response>
        /// <response code="401">If the user is not authenticated or authorized</response>
        /// <response code="500">If there is an internal server error</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(typeof(BadRequestResponseModel), 400)]
        [ProducesResponseType(typeof(void), 401)]
        [ProducesResponseType(typeof(InternalServerErrorResponseModel), 500)]
        public IActionResult Get([FromRoute] int id, [FromQuery] List<string> fields)
        {
            return base.GetBase(id, fields);
        }
    }
}
