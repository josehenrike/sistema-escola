using SistemaEscolar.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    public class ProfessorModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Titulacao { get; set; }
        public Status Status { get; set; }

        [ForeignKey(nameof(Disciplina))]
        public int DisciplinaId { get; set; }

        public virtual required DisciplinaModel Disciplina { get; set; }


        public static implicit operator ProfessorModel(DisciplinaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
