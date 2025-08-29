using _2_criando_web_api.Model;
using Microsoft.EntityFrameworkCore;

namespace _2_criando_web_api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<CategoriaModel> Categorias { get; set; }
    public DbSet<ProdutoModel> Produtos { get; set; }
}