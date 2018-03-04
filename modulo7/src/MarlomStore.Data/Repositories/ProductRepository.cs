using MarlomStore.Data.Context;
using System.Linq;
using MarlomStore.Domain.Products;
using System.Collections.Generic;

namespace MarlomStore.Data.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ApplicationDBContext context) : base(context) { }

        public override Product Get(int id) => _context.Products.SingleOrDefault(e => e.Id == id);

        public override IEnumerable<Product> Get() => _context.Products.AsEnumerable();

    }
}