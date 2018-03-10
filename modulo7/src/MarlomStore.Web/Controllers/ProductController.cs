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
            if(product == null)
                return View();

            var productViewModel = new ProductViewModel()
            return null;
            //ARRUMAR

        }
    }
}
