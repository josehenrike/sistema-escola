using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/relatorios")]
public class RelatorioController : ControllerBase
{
    private readonly string _connectionString = "Server=./;Database=turmadev-teste;User Id=sa;Password=TechShop27101712;Trusted_Connection=False; TrustServerCertificate=True;";

    [HttpGet("professores-detalhes")]
    public async Task<IActionResult> GetProfessoresDetalhes()
    {
        using var connection = new SqlConnection(_connectionString);
        var query = @"
            SELECT 
                p.Nome AS Professor,
                d.Nome AS Disciplina,
                t.Nome AS Turma,
                s.Nome AS Sala,
                p.Status AS ProfessorStatus
            FROM 
                Professores p
            INNER JOIN Disciplinas d ON d.Id = p.DisciplinaId
            INNER JOIN Salas s ON s.Id = d.SalaId
            INNER JOIN Turmas t ON t.SalaId = s.Id";

        var resultados = await connection.QueryAsync(query);
        return Ok(resultados);
    }
}
