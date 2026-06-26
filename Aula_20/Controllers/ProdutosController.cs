using Microsoft.AspNetCore.Mvc;

namespace Aula_20.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Mouse",
                "Teclado",
                "Monitor",
                "Webcam",
                "Headset"
            };

            return Json(produtos);
        }
    }
}
