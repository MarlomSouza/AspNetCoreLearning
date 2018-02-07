using Microsoft.AspNetCore.Mvc;

namespace modulo3.Controllers
{
    [Route("api/produto")]
    public class ProdutoController : Controller
    {
        [HttpGet("{id:int}")]
        public int get(int id){
            return id;
        }

    }
}
