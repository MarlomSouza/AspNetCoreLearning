using MarlomStore.Domain.Products;
using MarlomStore.Domain.Sales;
using Microsoft.EntityFrameworkCore;

namespace MarlomStore.Data.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}