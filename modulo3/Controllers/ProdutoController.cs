using Microsoft.AspNetCore.Mvc;
using modulo3.Models;

namespace modulo3.Controllers
{
    [Route("api/produto")]
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
        public string Post(Produto produto)
        {
            return produto.Nome;
        }
    }
}
