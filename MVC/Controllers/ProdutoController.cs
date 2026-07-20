using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        private readonly List<string> lista = new List<string>
        {
            "Notebook", "Mouse", "Teclado", "Monitor", "Headset"
        };

        [HttpGet]
        public IActionResult Index() => Json(lista);

        [HttpGet("{id}")]
        public IActionResult Detalhes(int id)
        {
            if (id < 0 || id >= lista.Count)
                return NotFound();

            return Content($"Produto: {lista[id]}");
        }

        [HttpGet("antiga")]
        public IActionResult Antiga() => RedirectToAction("Nova");

        [HttpGet("nova")]
        public IActionResult Nova() => Content("Você está na versão nova");
    }
}
