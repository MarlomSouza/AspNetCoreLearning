using MarlomStore.Domain.Products;
using MarlomStore.Domain.Repository;
using System.Linq;

namespace MarlomStore.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDBContext _context;

        public Repository(ApplicationDBContext context) => _context = context;

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public void Save(TEntity entity)
        {
            _context.Add<TEntity>(entity);
        }
    }
}