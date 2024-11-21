using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaEscolar.Models;

namespace SistemaEscolar.Data.Map
{
    public class SalaMap : IEntityTypeConfiguration<SalaModel>
    {
        public void Configure(EntityTypeBuilder<SalaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Capacidade).IsRequired().HasMaxLength(5);
            builder.Property(x => x.Local).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
