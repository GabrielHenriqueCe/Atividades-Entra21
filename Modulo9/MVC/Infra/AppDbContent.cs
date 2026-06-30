using MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC.Infra
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options) { }

        public DbSet<Produto> Produtos {  get; set; }
    }
}
