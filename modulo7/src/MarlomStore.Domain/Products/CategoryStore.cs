using MarlomStore.Domain.Dtos;
using MarlomStore.Domain.Repository;

namespace MarlomStore.Domain.Products
{
    public class CategoryStore
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStore(IRepository<Category> categoryRepository) => _categoryRepository = categoryRepository;

        public void Store(CategoryDto categoryDto)
        {
            var category = _categoryRepository.Get(categoryDto.Id);

            if (category == null)
            {
                category = new Category(categoryDto.Name);
                _categoryRepository.Save(category);
            }
            else
                category.Update(categoryDto.Name);

        }
    }
}
