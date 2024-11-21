using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorRepositorio _professorRepositorio;

        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProfessorModel>>> BuscarTodosProfessores()
        {
            List<ProfessorModel> professores = await _professorRepositorio.BuscarTodosProfessores();
            return Ok(professores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessorModel>> BuscarPorId(int id)
        {
            ProfessorModel professor = await _professorRepositorio.BuscarPorId(id);
            return Ok(professor);
        }

        [HttpPost]
        public async Task<ActionResult<ProfessorModel>> Cadastrar([FromBody]ProfessorModel professorModel)
        {
            ProfessorModel professor = await _professorRepositorio.Adicionar(professorModel);

            return Ok(professor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProfessorModel>> Atualizar([FromBody] ProfessorModel professorModel, int id)
        {
            professorModel.Id = id;
            ProfessorModel professor = await _professorRepositorio.Atualizar(professorModel, id);

            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfessorModel>> Excluir(int id)
        {
            bool excluido = await _professorRepositorio.Excluir( id);

            return Ok(excluido);
        }
    }
}
