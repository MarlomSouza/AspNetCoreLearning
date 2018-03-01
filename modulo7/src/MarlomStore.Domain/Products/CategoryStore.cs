using MarlomStore.Domain.Repository;

namespace MarlomStore.Domain.Products
{
    public class CategoryStore
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStore(IRepository<Category> categoryRepository) => _categoryRepository = categoryRepository;

        public void Store(int id, string name)
        {
            var category = _categoryRepository.Get(id);

            if (category == null)
            {
                category = new Category(name);
                _categoryRepository.Save(category);
            }
            else
                category.Update(name);

        }
    }
}
