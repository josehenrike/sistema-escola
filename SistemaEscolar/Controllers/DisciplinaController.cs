using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaRepositorio _disciplinaRepositorio;

        public DisciplinaController(IDisciplinaRepositorio disciplinaRepositorio)
        {
            _disciplinaRepositorio = disciplinaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<DisciplinaModel>>> BuscarTodasDisciplinas()
        {
            List<DisciplinaModel> disciplinas = await _disciplinaRepositorio.BuscarTodasDisciplinas();
            return Ok(disciplinas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DisciplinaModel>> BuscarPorId(int id)
        {
            ProfessorModel disciplina = await _disciplinaRepositorio.BuscarPorId(id);
            return Ok(disciplina);
        }

        [HttpPost]
        public async Task<ActionResult<DisciplinaModel>> Cadastrar([FromBody] DisciplinaModel disciplinaModel)
        {
            DisciplinaModel disciplina = await _disciplinaRepositorio.Adicionar(disciplinaModel);

            return Ok(disciplina);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<DisciplinaModel>> Atualizar([FromBody] DisciplinaModel disciplinaModel, int id)
        {
            disciplinaModel.Id = id;
            DisciplinaModel disciplina = await _disciplinaRepositorio.Atualizar(disciplinaModel, id);

            return Ok(disciplina);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DisciplinaModel>> Excluir(int id)
        {
            bool excluido = await _disciplinaRepositorio.Excluir(id);

            return Ok(excluido);
        }
    }
}
