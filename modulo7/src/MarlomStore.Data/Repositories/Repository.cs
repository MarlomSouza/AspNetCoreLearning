using MarlomStore.Data.Context;
using MarlomStore.Domain.Products;
using MarlomStore.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MarlomStore.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ApplicationDBContext _context;

        public Repository(ApplicationDBContext context) => _context = context;

        public virtual TEntity Get(int id) => _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);

        public virtual IEnumerable<TEntity> Get() => _context.Set<TEntity>().AsEnumerable();

        public void Save(TEntity entity) => _context.Add<TEntity>(entity);
    }
}