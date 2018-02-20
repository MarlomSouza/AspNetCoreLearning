namespace MarlomStore.Domain.Repository
{
    public interface IRepository<TEntity>
    {
        void Save(TEntity entity);
        TEntity Get(int id);

    }
}
