using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestFul.Data;
using RestFul.DTOs;

namespace RestFul.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetTodos()
        {
            return await _context.Produtos.ToListAsync();
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetPorId(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();
            return produto;
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Criar(ProdutoDto dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Preco = dto.Preco,
                EmailFornecedor = dto.EmailFornecedor
            };

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPorId), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, Produto dados)
        {
            var p = await _context.Produtos.FindAsync(id);
            if (p == null) return NotFound();

            p.Nome = dados.Nome;
            p.Preco = dados.Preco;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(int id)
        {
            var p = await _context.Produtos.FindAsync(id);
            if (p == null) return NotFound();

            _context.Produtos.Remove(p);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [AllowAnonymous]
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Produto>>> BuscarPorPreco(
    [FromQuery] decimal? precoMin,
    [FromQuery] decimal? precoMax)
        {
            var query = _context.Produtos.AsQueryable();

            if (precoMin.HasValue)
                query = query.Where(p => p.Preco >= precoMin.Value);

            if (precoMax.HasValue)
                query = query.Where(p => p.Preco <= precoMax.Value);

            return await query.ToListAsync();
        }
    }
}