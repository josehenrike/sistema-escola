using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaEscolar.Models;

namespace SistemaEscolar.Data.Map
{
    public class ProfessorMap : IEntityTypeConfiguration<ProfessorModel>
    {
        public void Configure(EntityTypeBuilder<ProfessorModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Titulacao).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
