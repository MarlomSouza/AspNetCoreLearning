using System.Linq;
using Microsoft.AspNetCore.Mvc;
using modulo4.Data;
using modulo4.Domain;

namespace modulo4.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;

            return View();
        }

        [HttpPost]
        public IActionResult Register(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}