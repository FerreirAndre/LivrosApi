using Microsoft.EntityFrameworkCore;
using LivrosApi.Models;
namespace LivrosApi.Context
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base (options)
        {
            
        }

        public DbSet<Livro> Livros { get; set; }
    }
}