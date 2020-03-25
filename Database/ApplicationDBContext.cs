using Microsoft.EntityFrameworkCore;
using CSharpEF.Models;

namespace CSharpEF.Database
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        // Utilizando método Lazy Moding
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        // Customização das tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("ProdutosV2");
            // modelBuilder.Entity<Produto>().Haskey(p. => p.CodigoBarras); // Definindo outra chave primária
            modelBuilder.Entity<Produto>().Property(p => p.Nome).IsRequired();
            modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLenght(100);
        }
    }
}
