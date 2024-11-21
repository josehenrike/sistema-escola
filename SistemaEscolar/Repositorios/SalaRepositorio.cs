using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Repositorios
{
    public class SalaRepositorio : ISalaRepositorio
    {
        private readonly SistemaEscolarDBContext _dbContext;

        public SalaRepositorio(SistemaEscolarDBContext sistemaEscolarDBContext)
        {
            _dbContext = sistemaEscolarDBContext;
        }

        public async Task<SalaModel> BuscarPorId(int id)
        {
            return await _dbContext.Salas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<SalaModel>> BuscarTodasSalas()
        {
            return await _dbContext.Salas.ToListAsync();
        }

        public async Task<SalaModel> Adicionar(SalaModel sala)
        {
            await _dbContext.Salas.AddAsync(sala);
            await _dbContext.SaveChangesAsync();

            return sala;
        }

        public async Task<SalaModel> Atualizar(SalaModel sala, int id)
        {
            SalaModel salaPorId = await BuscarPorId(id);

            if (salaPorId == null)
            {
                throw new Exception($"Sala para o ID: {id} não foi encontrado.");
            }

            salaPorId.Nome = sala.Nome;
            salaPorId.Local = sala.Local;
            salaPorId.Capacidade = sala.Capacidade;

            _dbContext.Salas.Update(sala);
            await _dbContext.SaveChangesAsync();

            return sala;
        }

        public async Task<bool> Excluir(int id)
        {
            SalaModel salaPorId = await BuscarPorId(id);

            if (salaPorId == null)
            {
                throw new Exception($"Sala para o ID: {id} não foi encontrado.");
            }

            _dbContext.Salas.Remove(salaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
