using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
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

        [HttpGet("lista-fixa")]
        public IActionResult ListaFixa() => Json(lista);

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

        // READ — listar todos (assíncrono, direto do banco)
        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return View(produtos);
        }

        // CREATE — salvar um novo produto
        [HttpPost]
        public async Task<IActionResult> Criar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // UPDATE — editar um produto existente
        [HttpPost]
        public async Task<IActionResult> Editar(int id, Produto dados)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();

            produto.Nome = dados.Nome;
            produto.Preco = dados.Preco;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // DELETE — remover um produto
        [HttpPost]
        public async Task<IActionResult> Excluir(int id)
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