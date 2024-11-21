using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Repositorios
{
    public class TurmaRepositorio : ITurmaRepositorio
    {
        private readonly SistemaEscolarDBContext _dbContext;

        public async Task<TurmaModel> BuscarPorId(int id)
        {
            return await _dbContext.Turmas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TurmaModel>> BuscarTodasTurmas()
        {
            return await _dbContext.Turmas.ToListAsync();
        }

        public TurmaRepositorio(SistemaEscolarDBContext sistemaEscolarDBContext)
        {
            _dbContext = sistemaEscolarDBContext;
        }

        public async Task<TurmaModel> Adicionar(TurmaModel turma)
        {
            await _dbContext.Turmas.AddAsync(turma);
            await _dbContext.SaveChangesAsync();

            return turma;
        }

        public async Task<TurmaModel> Atualizar(TurmaModel turma, int id)
        {
            TurmaModel turmaPorId = await BuscarPorId(id);

            if (turmaPorId == null)
            {
                throw new Exception($"Turma para o ID: {id} não foi encontrado.");
            }

            turmaPorId.Nome = turma.Nome;
            turmaPorId.Dia = turma.Dia;
            turmaPorId.Inicio = turma.Inicio;
            turmaPorId.Fim = turma.Fim;

            _dbContext.Turmas.Update(turma);
            await _dbContext.SaveChangesAsync();

            return turma;
        }

        public async Task<bool> Excluir(int id)
        {
            TurmaModel turmaPorId = await BuscarPorId(id);

            if (turmaPorId == null)
            {
                throw new Exception($"Turma para o ID: {id} não foi encontrado.");
            }

            _dbContext.Turmas.Remove(turmaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
