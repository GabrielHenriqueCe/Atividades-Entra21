using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string busca)
        {
            var query = _context.Alunos.AsQueryable();

            if (!string.IsNullOrEmpty(busca))
            {
                query = query.Where(a => a.Nome.Contains(busca));
            }

            var alunos = await query.ToListAsync();
            return View(alunos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);

            if (aluno == null)
                return NotFound();

            return View(aluno);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, Aluno dados)
        {
            if (id != dados.Id)
                return BadRequest();

            _context.Alunos.Update(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Excluir(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);

            if (aluno == null)
                return NotFound();

            return View(aluno);
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirConfirmado(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);

            if (aluno == null)
                return NotFound();

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}