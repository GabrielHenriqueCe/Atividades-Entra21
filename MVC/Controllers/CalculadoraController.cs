using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("calculadora")]
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("somar")]
        public IActionResult Somar(int a, int b)
            => Content($"{a + b}");

        [HttpGet("multiplicar")]
        public IActionResult Multiplicar(int a, int b)
            => Content($"{a * b}");

        [HttpGet("dividir")]
        public IActionResult Dividir(float a, float b)
         => Content($"{a / b}");

        [HttpGet("subtrair")]
        public IActionResult Subtrair(int a, int b)
            => Content($"{a / b}");
    }
}
