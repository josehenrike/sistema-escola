using SistemaEscolar.Models;

namespace SistemaEscolar.Repositorios.Interfaces
{
    public interface IDisciplinaRepositorio
    {
        Task<List<DisciplinaModel>> BuscarTodasDisciplinas();
        Task<DisciplinaModel> BuscarPorId(int id);
        Task<DisciplinaModel> Adicionar(DisciplinaModel disciplina);
        Task<DisciplinaModel> Atualizar(DisciplinaModel disciplina, int id);
        Task<bool> Excluir(int id);
    }
}
