using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();

        #region asp-net-core 1.1
        // static void Main(string[] args)
        // {
        //     var host = new WebHostBuilder()
        //         .UseKestrel()
        //         .UseStartup<Startup>()
        //         .UseContentRoot(Directory.GetCurrentDirectory())
        //         .Build();

        //     host.Run();
        // }
        #endregion
    }
}
