using System.Threading.Tasks;
using MarlomStore.Domain;

namespace MarlomStore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context) => _context = context;

        public async Task CommitAsync() => await _context.SaveChangesAsync();
    }
}