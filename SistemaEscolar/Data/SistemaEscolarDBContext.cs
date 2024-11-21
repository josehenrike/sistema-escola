using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data.Map;
using SistemaEscolar.Models;

namespace SistemaEscolar.Data
{
    public class SistemaEscolarDBContext : DbContext
    {
        public SistemaEscolarDBContext(DbContextOptions<SistemaEscolarDBContext> options)
            : base (options)
        {
        }

        public DbSet<ProfessorModel> Professores { get; set; }
        public DbSet<DisciplinaModel> Disciplinas { get; set; }
        public DbSet<SalaModel> Salas { get; set; }
        public DbSet<TurmaModel> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new SalaMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
