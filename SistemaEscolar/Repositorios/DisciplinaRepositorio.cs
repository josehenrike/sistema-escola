using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Repositorios
{
    public class DisciplinaRepositorio : IDisciplinaRepositorio
    {
        private readonly SistemaEscolarDBContext _dbContext;

        public DisciplinaRepositorio(SistemaEscolarDBContext sistemaEscolarDBContext)
        {
            _dbContext = sistemaEscolarDBContext;
        }

        public async Task<DisciplinaModel> BuscarPorId(int id)
        {
            return await _dbContext.Disciplinas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<DisciplinaModel>> BuscarTodasDisciplinas()
        {
            return await _dbContext.Disciplinas.ToListAsync();
        }

        public async Task<DisciplinaModel> Adicionar(DisciplinaModel disciplina)
        {
            await _dbContext.Disciplinas.AddAsync(disciplina);
            await _dbContext.SaveChangesAsync();

            return disciplina;
        }

        public async Task<DisciplinaModel> Atualizar(DisciplinaModel disciplina, int id)
        {
            DisciplinaModel disciplinaPorId = await BuscarPorId(id);

            if (disciplinaPorId == null)
            {
                throw new Exception($"Disciplina para o ID: {id} não foi encontrado.");
            }

            disciplinaPorId.Nome = disciplina.Nome;
            disciplinaPorId.Codigo = disciplina.Codigo;
            disciplinaPorId.Periodo = disciplina.Periodo;

            _dbContext.Disciplinas.Update(disciplinaPorId);
            await _dbContext.SaveChangesAsync();

            return disciplinaPorId;
        }

        public async Task<bool> Excluir(int id)
        {
            DisciplinaModel disciplinaPorId = await BuscarPorId(id);

            if (disciplinaPorId == null)
            {
                throw new Exception($"Disciplina para o Código: {id} não foi encontrado.");
            }

            _dbContext.Disciplinas.Remove(disciplinaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
