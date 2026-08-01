using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataHoraService _dataHoraService;

        public HomeController(IDataHoraService dataHoraService)
        {
            _dataHoraService = dataHoraService;
        }

        public IActionResult Index()
        {
            ViewBag.DataAtual = _dataHoraService.ObterDataAtual();
            return View();
        }


        public IActionResult SobreMim()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
