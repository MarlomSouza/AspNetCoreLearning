using MarlomStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MarlomStore.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string DBConnection)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(DBConnection, x => x.MigrationsAssembly("MarlomStore.Data")));
        }
    }
}