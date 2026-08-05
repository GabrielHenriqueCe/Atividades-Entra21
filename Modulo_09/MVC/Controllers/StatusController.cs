using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("status")]
    public class StatusController : Controller
    {
        private readonly List<string> servicos = new List<string>
        {
            "banco", "api", "cache"
        };

        [HttpGet]
        public IActionResult Index()
        {
            return Json(new { sistema = "online", hora = DateTime.Now });
        }

        
        [HttpGet("{servico}")]
        public IActionResult Servico(string servico)
        {
            if (servicos.Contains(servico)  == false)
            {
                return NotFound();
            }

            return Content($"{servico} Operacional");
        }
    }
}
