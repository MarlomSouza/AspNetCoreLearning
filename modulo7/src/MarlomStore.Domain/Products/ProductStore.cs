using MarlomStore.Domain.Dtos;
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

        public void Store(ProductDto productDto)
        {
            var category = _categoryRepository.Get(productDto.CategoryId);
            DomainException.When(category == null, "Category invalid!");

            var product = _productRepository.Get(productDto.Id);

            if (product == null)
            {
                product = new Product(productDto.Name, productDto.Price, productDto.StockQuantity, category);
                _productRepository.Save(product);
            }
            else
                product.Update(productDto.Name, productDto.Price, productDto.StockQuantity, category);

        }
    }
}
