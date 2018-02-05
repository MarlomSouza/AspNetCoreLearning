using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace hosting
{
    public class Startup
    {
        private IConfiguration _configuration;

        #region asp-net-core 1.1
        // public Startup(IHostingEnvironment env)
        // {
        //     var builder = new ConfigurationBuilder()
        //         .SetBasePath(env.ContentRootPath)
        //         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //         .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        //         .AddEnvironmentVariables();
        //     _configuration = builder.Build();
        // }

        #endregion
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<MyMiddleware>();
            var applicationName = _configuration.GetValue<string>("ApplicationName");
            app.Run(context => context.Response.WriteAsync($"Este aqui é um middleWare, Aplicacao = {applicationName}"));

        }
    }
}