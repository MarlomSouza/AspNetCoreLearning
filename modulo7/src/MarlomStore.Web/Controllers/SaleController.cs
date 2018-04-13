using System.Linq;
using MarlomStore.Domain.Products;
using MarlomStore.Domain.Repository;
using MarlomStore.Domain.Sales;
using MarlomStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarlomStore.Web.Controllers
{
    public class SaleController : Controller
    {
        private readonly IRepository<Product> _productRepository;
        private readonly SaleFactory _saleFactory;

        public SaleController(IRepository<Product> productRepository, SaleFactory saleFactory)
        {
            _productRepository = productRepository;
            _saleFactory = saleFactory;
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
                Products = productViewModel
            };

            return View(sale);
        }

        [HttpPost]
        public IActionResult Create(SaleViewModel model)
        {
            _saleFactory.Create(model.ClientName, model.Product.Id, model.Quantity);
            return Ok();
        }

    }
}
