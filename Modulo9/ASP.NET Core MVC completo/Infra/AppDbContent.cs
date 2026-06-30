using AspNetCoreMvcCompleto.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcCompleto.Infra
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options) { }

        public DbSet<Produto> Produtos {  get; set; }
    }
}
