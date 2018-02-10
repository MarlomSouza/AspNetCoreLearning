using Microsoft.AspNetCore.Mvc;
using modulo3.Models;

namespace modulo3.Controllers
{
    [Route("/produto")]
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Save(Produto produto)
        {
            if (ModelState.IsValid)
                ViewBag.validacao = "Produto cadastrado com sucesso!";
            else
                ViewBag.validacao = "Produto Incorreto!";

            return View("Index");

        }
    }
}
