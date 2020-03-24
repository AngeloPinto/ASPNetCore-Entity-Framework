using Microsoft.EntityFrameworkCore;
using CSharpEF.Models;

namespace CSharpEF.Database
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
        : base(options) 
        {

        }
    }
}
