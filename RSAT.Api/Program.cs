using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NovusConsulting.Data;
using System;

namespace RSAT.Api
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            //Seed => https://stackoverflow.com/questions/45885019/asp-net-core-2-get-instance-of-db-context?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
            var webHost = CreateWebHostBuilder(args).Build();
            var serviceScopeFactory = (IServiceScopeFactory)webHost.Services.GetService(typeof(IServiceScopeFactory));
            using (var scope = serviceScopeFactory.CreateScope())
            {
                try
                {
                    var services = scope.ServiceProvider;
                    var dataLayer = services.GetRequiredService<IDataLayer>();
                    dataLayer.Seed();
                }
                catch (Exception exception)
                {
                    var message = string.Format("{0}: {1}", exception.Message, exception.StackTrace);
                    Console.WriteLine(message);
                }
            }
            webHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}
