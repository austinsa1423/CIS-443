using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

/********************************************************************************************
 * https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-2.2
 * 
 * Add-Migration Initial
 * Update-Database
 * 
********************************************************************************************/


namespace Shopper
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateWebHostBuilder(args).Build().Run();
        //}

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /*******************************************************************************
         * The following BuildWebHost method is required for version
         * Fall2019 - B
         * *****************************************************************************/
        public static IWebHost BuildWebHost(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>()
                 .UseDefaultServiceProvider(options =>
                     options.ValidateScopes = false)
                 .Build();




        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
