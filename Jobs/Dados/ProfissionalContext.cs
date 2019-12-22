using Jobs.Models;
using Microsoft.EntityFrameworkCore;

namespace Jobs.Dados
{
    public class ProfissionalContext : DbContext
    {
        public ProfissionalContext(DbContextOptions<ProfissionalContext> options) : base(options)
        {

        }

        public DbSet<Profissional> Profissionais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profissional>().ToTable("TbProfissional"); 
        }
    }
}
