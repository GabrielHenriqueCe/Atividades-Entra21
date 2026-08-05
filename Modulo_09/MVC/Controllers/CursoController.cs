using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;
using MVC.Services;

namespace MVC.Controllers
{
    [Authorize]
    public class CursosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICalculadoraCargaHorariaService _calculadora;

        public CursosController(AppDbContext context, ICalculadoraCargaHorariaService calculadora)
        {
            _context = context;
            _calculadora = calculadora;
        }

        // Qualquer usuário logado pode ver a listagem
        public async Task<IActionResult> Index()
        {
            var cursos = await _context.Cursos
                .OrderByDescending(c => c.CargaHoraria)
                .ToListAsync();

            ViewBag.Total = cursos.Count;

            return View(cursos);
        }

        [Authorize(Roles = "Professor")]
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [Authorize(Roles = "Professor")]
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

        [Authorize(Roles = "Professor")]
        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null) return NotFound();
            return View(curso);
        }

        [Authorize(Roles = "Professor")]
        [HttpPost]
        public async Task<IActionResult> Editar(int id, Curso dados)
        {
            if (id != dados.Id) return BadRequest();
            if (!ModelState.IsValid) return View(dados);

            _context.Cursos.Update(dados);
            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Curso atualizado com sucesso!";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Professor")]
        [HttpGet]
        public async Task<IActionResult> Excluir(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null) return NotFound();
            return View(curso);
        }

        [Authorize(Roles = "Professor")]
        [HttpPost]
        public async Task<IActionResult> ExcluirConfirmado(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                await _context.SaveChangesAsync();
            }

            TempData["Mensagem"] = "Curso excluído com sucesso!";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Professor")]
        [HttpGet]
        public async Task<IActionResult> Detalhes(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null) return NotFound();

            ViewBag.DiasUteis = _calculadora.ConverterParaDiasUteis(curso.CargaHoraria);
            return View(curso);
        }
    }
}