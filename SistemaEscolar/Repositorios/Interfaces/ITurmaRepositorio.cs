using SistemaEscolar.Models;

namespace SistemaEscolar.Repositorios.Interfaces
{
    public interface ITurmaRepositorio
    {
        Task<TurmaModel> BuscarPorId(int id);
        Task<List<TurmaModel>> BuscarTodasTurmas();
        Task<TurmaModel> Adicionar(TurmaModel turma);
        Task<TurmaModel> Atualizar(TurmaModel turma, int id);
        Task<bool> Excluir(int id);
    }
}
