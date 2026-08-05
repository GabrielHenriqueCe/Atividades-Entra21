using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;

        private readonly List<string> lista = new List<string>
        {
            "Notebook", "Mouse", "Teclado", "Monitor", "Headset"
        };

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet("lista-fixa")]
        public IActionResult ListaFixa() => Json(lista);

        [HttpGet("antiga")]
        public IActionResult Antiga() => RedirectToAction("Nova");

        [HttpGet("nova")]
        public IActionResult Nova() => Content("Você está na versão nova");

        [AllowAnonymous]
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return View(produtos);
        }

        [HttpGet("criar")]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost("criar")]
        public async Task<IActionResult> Criar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet("editar/{id}")]
        public async Task<IActionResult> Editar(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();

            return View(produto);
        }

        [HttpPost("editar/{id}")]
        public async Task<IActionResult> Editar(int id, Produto dados)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();

            produto.Nome = dados.Nome;
            produto.Preco = dados.Preco;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();

            return View(produto);
        }

        [HttpPost("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id, Produto dados)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}