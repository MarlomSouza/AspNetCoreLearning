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

        [HttpGet("{id:int}")]
        public string get(int id)
        {
            return HttpContext.Request.Path + id;
        }

        [HttpPost]
        public IActionResult Save(Produto produto)
        {
            if (ModelState.IsValid)
                ViewBag.validacao = "Produto cadastrado com sucesso!";

            return View();

        }
    }
}
