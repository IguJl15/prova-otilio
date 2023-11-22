using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prova.Models;

namespace Prova.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Carrinho> Carrinho { get; set; }
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
}
