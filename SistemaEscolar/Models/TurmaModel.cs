using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace SistemaEscolar.Models
{
    public class TurmaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Dia { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string? Inicio { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string? Fim { get; set; }

        [ForeignKey(nameof(Sala))]
        public int SalaId { get; set; }

        public virtual required SalaModel Sala { get; set; }

    }
}
