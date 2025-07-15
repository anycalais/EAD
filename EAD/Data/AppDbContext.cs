using Microsoft.EntityFrameworkCore;

namespace NomeDoProjeto.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Defina suas entidades (tabelas) aqui
        public DbSet<Produto> Produtos { get; set; }
    }
}
