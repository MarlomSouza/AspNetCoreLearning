using MarlomStore.Domain.Repository;

namespace MarlomStore.Domain.Products
{
    public class ProductStore
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductStore(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public void Store(int id, string name, decimal price, int stockQuantity, int categoryId)
        {
            var category = _categoryRepository.Get(categoryId);
            DomainException.When(category == null, "Category invalid!");

            var product = _productRepository.Get(id);

            if (product == null)
            {
                product = new Product(name, price, stockQuantity, category);
                _productRepository.Save(product);
            }
            else
                product.Update(name,price, stockQuantity, category);

        }
    }
}
