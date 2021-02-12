using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NLog.Web;

namespace DevExtremeAspNetCoreResponsiveApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();            
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://localhost:9000")
                .UseStartup<Startup>()
            /*.ConfigureLogging(logging =>
                {
                    logging.ConfigureNLog("nlog.config").GetCurrentClassLogger();
                    
                }).UseNLog()*/
                .Build();
    }
}
