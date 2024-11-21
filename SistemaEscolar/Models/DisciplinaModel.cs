using SistemaEscolar.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    public class DisciplinaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        public int Periodo { get; set; }
        public Status Status { get; set; }

        [ForeignKey(nameof(Sala))]
        public int SalaId { get; set; }

        public virtual required SalaModel Sala { get; set; }
    }
}
