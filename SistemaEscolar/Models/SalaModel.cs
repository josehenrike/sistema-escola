using SistemaEscolar.Enums;

namespace SistemaEscolar.Models
{
    public class SalaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Local { get; set; }
        public int Capacidade { get; set; }
        public Status Status { get; set; }

        public virtual required ICollection<DisciplinaModel> Disciplinas { get; set; }

        public virtual required ICollection<TurmaModel> Turmas { get; set; }

        public static implicit operator SalaModel(TurmaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
