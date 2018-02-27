using System.Threading.Tasks;

namespace MarlomStore.Domain
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}