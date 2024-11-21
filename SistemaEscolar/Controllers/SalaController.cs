using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaEscolar.Models;
using SistemaEscolar.Repositorios;
using SistemaEscolar.Repositorios.Interfaces;

namespace SistemaEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly ISalaRepositorio _salaRepositorio;

        public SalaController(ISalaRepositorio salaRepositorio)
        {
            _salaRepositorio = salaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<SalaModel>>> BuscarTodasSalas()
        {
            List<SalaModel> salas = await _salaRepositorio.BuscarTodasSalas();
            return Ok(salas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalaModel>> BuscarPorId(int id)
        {
            SalaModel sala = await _salaRepositorio.BuscarPorId(id);
            return Ok(sala);
        }

        [HttpPost]
        public async Task<ActionResult<SalaModel>> Cadastrar([FromBody] SalaModel salaModel)
        {
            SalaModel sala = await _salaRepositorio.Adicionar(salaModel);

            return Ok(sala);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SalaModel>> Atualizar([FromBody] SalaModel salaModel, int id)
        {
            salaModel.Id = id;
            SalaModel sala = await _salaRepositorio.Atualizar(salaModel, id);

            return Ok(sala);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SalaModel>> Excluir(int id)
        {
            bool excluido = await _salaRepositorio.Excluir(id);

            return Ok(excluido);
        }
    }
}
