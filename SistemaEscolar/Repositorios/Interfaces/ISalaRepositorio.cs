using SistemaEscolar.Models;

namespace SistemaEscolar.Repositorios.Interfaces
{
    public interface ISalaRepositorio
    {
        Task<List<SalaModel>> BuscarTodasSalas();
        Task<SalaModel> BuscarPorId(int id);
        Task<SalaModel> Adicionar(SalaModel sala);
        Task<SalaModel> Atualizar(SalaModel sala, int id);
        Task<bool> Excluir(int id);
    }
}
