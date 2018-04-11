using System.Linq;
using MarlomStore.Domain.Products;
using MarlomStore.Domain.Repository;
using MarlomStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarlomStore.Web.Controllers
{
    public class SaleController : Controller
    {
        private readonly IRepository<Product> _productRepository;

        public SaleController(IRepository<Product> productRepository)
        {

            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var products = _productRepository.Get();
            if (!products.Any())
                return View();

            var productViewModel = products.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Name = p.Name
            });

            var sale = new SaleViewModel()
            {
                ProductViewModel = productViewModel
            };

            return View(sale);
        }



    }
}
