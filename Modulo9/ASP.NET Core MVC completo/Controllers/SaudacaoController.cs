using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreMvcCompleto.Controllers
{
    public class SaudacaoController : Controller
    {
        public IActionResult Ola(string nome)
        {
            return Content($"Olá, {nome}! Bem-vindo ao ASP.NET Core.");
        }
    }
}