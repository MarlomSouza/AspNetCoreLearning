using Microsoft.AspNetCore.Mvc;
using MarlomStore.Domain.Products;
using MarlomStore.Web.ViewModels;
using MarlomStore.Domain.Repository;
using System.Linq;

namespace MarlomStore.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStore _caterogyStore;
        private readonly IRepository<Category> _categoryRepository;

        public CategoryController(CategoryStore categoryStore, IRepository<Category> categoryRepository)
        {
            _caterogyStore = categoryStore;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var categories = _categoryRepository.Get();
            var viewModel = categories.Select(c => new CategoryViewModel { Id = c.Id, Name = c.Name });
            return View(viewModel);
        }

        public IActionResult CreateOrEdit(int id)
        {
            if (id == 0)
                return View();

            var category = _categoryRepository.Get(id);
            var categoryViewModel = new CategoryViewModel() { Id = category.Id, Name = category.Name };

            return View(categoryViewModel);
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryViewModel categoryViewModel)
        {
            _caterogyStore.Store(categoryViewModel.Id, categoryViewModel.Name);
            return View();
        }


    }
}
