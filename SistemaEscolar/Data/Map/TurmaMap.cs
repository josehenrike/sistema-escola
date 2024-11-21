using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaEscolar.Models;

namespace SistemaEscolar.Data.Map
{
    public class TurmaMap : IEntityTypeConfiguration<TurmaModel>
    {
        public void Configure(EntityTypeBuilder<TurmaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Dia).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Inicio).IsRequired().HasMaxLength(5);
            builder.Property(x => x.Fim).IsRequired().HasMaxLength(5);
        }
    }
}
