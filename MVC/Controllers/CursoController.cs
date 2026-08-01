using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class CursosController : Controller
    {
        private readonly AppDbContext _context;

        public CursosController(AppDbContext context)
        {
            _context = context;
        }

        // READ — listar, ordenado por CargaHoraria decrescente
        public async Task<IActionResult> Index()
        {
            var cursos = await _context.Cursos
                .OrderByDescending(c => c.CargaHoraria)
                .ToListAsync();

            ViewBag.Total = cursos.Count;

            return View(cursos);
        }

        // CREATE
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Curso curso)
        {
            if (!ModelState.IsValid)
                return View(curso);

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Curso cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        // UPDATE
        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);

            if (curso == null)
                return NotFound();

            return View(curso);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, Curso dados)
        {
            if (id != dados.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return View(dados);

            _context.Cursos.Update(dados);
            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Curso atualizado com sucesso!";
            return RedirectToAction("Index");
        }

        // DELETE
        [HttpGet]
        public async Task<IActionResult> Excluir(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);

            if (curso == null)
                return NotFound();

            return View(curso);
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirConfirmado(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);

            if (curso == null)
                return NotFound();

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Curso excluído com sucesso!";
            return RedirectToAction("Index");
        }
    }
}