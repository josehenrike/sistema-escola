using SistemaEscolar.Models;

namespace SistemaEscolar.Repositorios.Interfaces
{
    public interface IProfessorRepositorio
    {
        Task<List<ProfessorModel>> BuscarTodosProfessores();
        Task<ProfessorModel> BuscarPorId(int id);
        Task<ProfessorModel> Adicionar(ProfessorModel professor);
        Task<ProfessorModel> Atualizar(ProfessorModel professor, int id);
        Task<bool> Excluir(int id);
    }
}