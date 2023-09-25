using AspNetCoreIdentity.Mvc.Habilitar.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Mvc.Habilitar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
