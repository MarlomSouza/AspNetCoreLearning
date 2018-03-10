using System.Linq;
using MarlomStore.Domain.Products;
using MarlomStore.Domain.Repository;
using MarlomStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarlomStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductStore _productStore;
        private IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductController(ProductStore productStore, IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productStore = productStore;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var product = _productRepository.Get();
            if (!product.Any())
                return View();

            var productViewModel = product.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                CategoryId = p.Category.Id,
                CategoryName = p.Category.Name
            });

            return View(productViewModel);
        }
    }
}
