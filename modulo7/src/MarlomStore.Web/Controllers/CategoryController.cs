
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarlomStore.Web.Models;
using MarlomStore.Domain.Dtos;
using MarlomStore.Domain.Products;

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
        public IActionResult CreateOrEdit(CategoryDto categoryDto)
        {
            _caterogyStore.Store(categoryDto);
            return View();
        }


    }
}
