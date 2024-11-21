using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaEscolar.Models;

namespace SistemaEscolar.Data.Map
{
    public class DisciplinaMap : IEntityTypeConfiguration<DisciplinaModel>
    {
        public void Configure(EntityTypeBuilder<DisciplinaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Codigo).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Periodo).IsRequired().HasMaxLength(5);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
