using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class SaudacaoController : Controller
    {
        [HttpGet]
        public IActionResult Index(string nome)
        {
            return View();
        }

        [HttpGet]  // GET 
        public IActionResult Ola(string nome)
            => Content($"Ola {nome}. Bem vindo ao Asp.Net Core.");
    }
}
