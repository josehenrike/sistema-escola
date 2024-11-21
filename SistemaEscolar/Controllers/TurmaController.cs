using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepositorio _turmaRepositorio;

        public TurmaController(ITurmaRepositorio turmaRepositorio)
        {
            _turmaRepositorio = turmaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<TurmaModel>>> BuscarTodasTurmas()
        {
            List<TurmaModel> turmas = await _turmaRepositorio.BuscarTodasTurmas();
            return Ok(turmas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TurmaModel>> BuscarPorId(int id)
        {
            TurmaModel turma = await _turmaRepositorio.BuscarPorId(id);
            return Ok(turma);
        }

        [HttpPost]
        public async Task<ActionResult<TurmaModel>> Cadastrar([FromBody] TurmaModel turmaModel)
        {
            TurmaModel turma = await _turmaRepositorio.Adicionar(turmaModel);

            return Ok(turma);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TurmaModel>> Atualizar([FromBody] TurmaModel turmaModel, int id)
        {
            turmaModel.Id = id;
            SalaModel sala = await _turmaRepositorio.Atualizar(turmaModel, id);

            return Ok(sala);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TurmaModel>> Excluir(int id)
        {
            bool excluido = await _turmaRepositorio.Excluir(id);

            return Ok(excluido);
        }
    }
}
