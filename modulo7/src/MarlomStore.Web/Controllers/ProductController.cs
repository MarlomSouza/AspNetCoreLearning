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
                Category = new CategoryViewModel() { Id = p.Category.Id, Name = p.Category.Name }
            });

            return View(productViewModel);
        }

        public IActionResult CreateOrEdit(int id)
        {
            var viewModel = new ProductViewModel();
            if (id == 0)
                viewModel.Categories = _categoryRepository.Get().Select(c => new CategoryViewModel() { Id = c.Id, Name = c.Name });

            var product = _productRepository.Get(id);

            if (product != null)
            {
                viewModel.Id = product.Id;
                viewModel.Name = product.Name;
                viewModel.StockQuantity = product.StockQuantity;
                viewModel.Price = product.Price;
                viewModel.Category.Id = product.Category.Id;
                viewModel.Category.Name = product.Category.Name;
            }

            return View(viewModel);
        }

    }
}
