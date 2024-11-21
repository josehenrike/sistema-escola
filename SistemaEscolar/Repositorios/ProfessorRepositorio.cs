using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Repositorios
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {
        private readonly SistemaEscolarDBContext _dbContext;

        public ProfessorRepositorio(SistemaEscolarDBContext sistemaEscolarDBContext)
        {
            _dbContext = sistemaEscolarDBContext;
        }

        public async Task<ProfessorModel> BuscarPorId(int id)
        {
            return await _dbContext.Professores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ProfessorModel>> BuscarTodosProfessores()
        {
            return await _dbContext.Professores.ToListAsync();
        }

        public async Task<ProfessorModel> Adicionar(ProfessorModel professor)
        {
            await _dbContext.Professores.AddAsync(professor);
            await _dbContext.SaveChangesAsync();

            return professor;
        }

        public async Task<ProfessorModel> Atualizar(ProfessorModel professor ,int id)
        {
            ProfessorModel professorPorId = await BuscarPorId(id);

            if (professorPorId == null)
            {
                throw new Exception($"Professor para o ID: {id} não foi encontrado.");
            }

            professorPorId.Nome = professor.Nome;
            professorPorId.Cpf = professor.Cpf;
            professorPorId.Titulacao = professor.Titulacao;

            _dbContext.Professores.Update(professorPorId);
            await _dbContext.SaveChangesAsync();

            return professorPorId;
        }

        public async Task<bool> Excluir(int id)
        {
            ProfessorModel professorPorId = await BuscarPorId(id);

            if (professorPorId == null)
            {
                throw new Exception($"Professor para o ID: {id} não foi encontrado.");
            }

            _dbContext.Professores.Remove(professorPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
