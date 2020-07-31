using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using NovusConsulting.Data.Models;
using NovusConsulting.Data;
using NovusConsulting.Data.SqlServer;

namespace RSAT.Api
{
    public class Startup
    {
        private IConfiguration _configuration = null;
        private IHostingEnvironment _hostingEnvironment = null;

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //DataLayer configuration
            var configuration = new ConfigurationModel()
            {
                JwtKey = _configuration["JwtKey"],
                JwtIssuer = _configuration["JwtIssuer"],
                MasterConnectionString = _configuration["MasterConnectionString"],
                EntityFrameworkConnectionString = _configuration["EntityFrameworkConnectionString"],
                SqlConnectionString = _configuration["SqlConnectionString"],
                FilePath = Path.Combine(_hostingEnvironment.WebRootPath, "files") + @"\",
                Olap = _configuration["Olap"],
                Processor = _configuration["Processor"],
                Localization = _configuration["Localization"],
                UseProxy = Convert.ToBoolean(_configuration["UseProxy"]),
                ProxyUrl = _configuration["ProxyUrl"],
                GeneratePostLogs = Convert.ToBoolean(_configuration["GeneratePostLogs"]),
                GeneratePutLogs = Convert.ToBoolean(_configuration["GeneratePutLogs"]),
                GenerateDeleteLogs = Convert.ToBoolean(_configuration["GenerateDeleteLogs"]),
                GenerateGetLogs = Convert.ToBoolean(_configuration["GenerateGetLogs"]),
                AdministrationSchema = _configuration["AdministrationSchema"]
            };
            services.AddScoped<NovusConsulting.Data.IDataLayer>(implementation => new RSAT.Api.Data.DataLayer(new RSAT.Api.Data.ApplicationDbContext(configuration.EntityFrameworkConnectionString), configuration));
            services.AddScoped<NovusConsulting.Data.IEtlLayer>(implementation => new RSAT.Api.Data.EtlLayer(new RSAT.Api.Data.DataLayer(new RSAT.Api.Data.ApplicationDbContext(configuration.EntityFrameworkConnectionString), configuration)));
            //MVC and json camelcase configuration
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
                    options.SerializerSettings.DateFormatString = "dd/MM/yyyy HH:mm:ss";
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter()); //https://gist.github.com/regisdiogo/27f62ef83a804668eb0d9d0f63989e3e
                });
            //https://www.devexpress.com/Support/Center/Question/Details/T537131/fileuploader-causes-the-multipart-body-length-limit-16384-exceeded-error-in-an-asp-net
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = long.MaxValue;
                x.MemoryBufferThreshold = int.MaxValue;
            });
            //Swagger configuration
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "RSAT API",
                    Description = "RSAT API is an awesome API for managing employee records.",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Novus Consulting", Email = "info@novusconsult.net", Url = "http://novusconsult.net/" }
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                //JWT Authorization https://ppolyzos.com/2017/10/30/add-jwt-bearer-authorization-to-swagger-and-asp-net-core/
                var security = new Dictionary<string, IEnumerable<string>> { { "Bearer", new string[] { } } };
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                c.AddSecurityRequirement(security);
            });
            //Cookie Authentication https://docs.microsoft.com/en-us/aspnet/core/security/authentication/cookie?view=aspnetcore-2.1&tabs=aspnetcore2x
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.AccessDeniedPath = "/account/unauthorized";
                    options.LoginPath = "/account/login";
                    options.ExpireTimeSpan = TimeSpan.FromHours(24);
                });
            //JWT Authentication https://auth0.com/blog/securing-asp-dot-net-core-2-applications-with-jwts/
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = _configuration["JwtIssuer"],
                        ValidAudience = _configuration["JwtIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]))
                    };
                });
            //CORS configuration https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.1
            services.AddCors(options =>
            {
                options.AddPolicy("Cors", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("Cors"));
            });
            //Response caching configuration => https://docs.microsoft.com/en-us/aspnet/core/performance/caching/middleware?view=aspnetcore-2.1
            services.AddResponseCaching();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Errors configuration
            app.UseDeveloperExceptionPage();
            //Authentication configuration
            app.UseAuthentication();
            //Static files configuration: http://fiyazhasan.me/story-of-file-uploading-in-asp-net-core-part-iii-streaming-files/
            app.UseStaticFiles();
            //Swagger configuration
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "api-explorer";
                // Adding the relative path for the virtual directory: https://github.com/domaindrivendev/Swashbuckle/issues/971
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "V1");
            });
            //CORS configuration https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.1
            app.UseCors("Cors");
            //Response caching configuration => https://docs.microsoft.com/en-us/aspnet/core/performance/caching/middleware?view=aspnetcore-2.1
            app.UseResponseCaching();
            //MVC configuration
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Dashboard}/{action=Index}/{id?}");
            });
        }
    }
}