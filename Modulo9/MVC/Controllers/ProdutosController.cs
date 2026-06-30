using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly List<string> _produtos = new List<string>
        {
            "Mouse", "Teclado", "Monitor", "Webcam", "Headset"
        };

        public IActionResult Index()
        {
            return Json(_produtos);
        }

        [HttpGet("Produtos/Detalhes/{id}")]
        public IActionResult Detalhes(int id)
        {
            if (id < 0 || id >= _produtos.Count)
            {
                return NotFound();
            }

            return Content(_produtos[id]);
        }

        public IActionResult Antiga()
        {
            return RedirectToAction("Nova");
        }

        public IActionResult Nova()
        {
            return Content("Você está na versão nova!");
        }
    }
}