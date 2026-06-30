using Microsoft.AspNetCore.AspNetCoreMvcCompleto;

namespace AspNetCoreMvcCompleto.Controllers
{
    [Route("status")]
    public class StatusController : Controller
    {
        private readonly List<string> _servicosConhecidos = new List<string>
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
            bool existe = _servicosConhecidos.Contains(servico.ToLower());

            if (!existe)
            {
                return NotFound($"Serviço '{servico}' não encontrado.");
            }

            return Json(new { servico = servico, status = "operacional" });
        }
    }
}