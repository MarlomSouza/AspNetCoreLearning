using Microsoft.AspNetCore.Mvc;
using MarlomStore.Domain.Products;
using MarlomStore.Web.ViewModels;

namespace MarlomStore.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStore _caterogyStore;

        public CategoryController(CategoryStore categoryStore)
        {
            _caterogyStore = categoryStore;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryViewModel categoryViewModel)
        {
            _caterogyStore.Store(categoryViewModel.Id, categoryViewModel.Name);
            return View();
        }


    }
}
