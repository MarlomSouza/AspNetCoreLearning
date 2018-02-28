using MarlomStore.Data;
using MarlomStore.Domain;
using MarlomStore.Domain.Products;
using MarlomStore.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MarlomStore.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string DBConnection)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(DBConnection));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(CategoryStore));

        }
    }
}