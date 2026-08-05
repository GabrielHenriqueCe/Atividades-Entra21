using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace RestFul.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly List<string> produtos = new List<string> { "Mouse", "Teclado" };

        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult Produto(int id)
        {
            if (id < 0 || id >= produtos.Count())
                return NotFound();

            return Ok(produtos[id]);
        }
}
}
