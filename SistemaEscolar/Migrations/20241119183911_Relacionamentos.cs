using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEscolar.Migrations
{
    /// <inheritdoc />
    public partial class Relacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Professores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Disciplinas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_SalaId",
                table: "Turmas",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_DisciplinaId",
                table: "Professores",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_SalaId",
                table: "Disciplinas",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Salas_SalaId",
                table: "Disciplinas",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Disciplinas_DisciplinaId",
                table: "Professores",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Salas_SalaId",
                table: "Turmas",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Salas_SalaId",
                table: "Disciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Disciplinas_DisciplinaId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Salas_SalaId",
                table: "Turmas");

            migrationBuilder.DropIndex(
                name: "IX_Turmas_SalaId",
                table: "Turmas");

            migrationBuilder.DropIndex(
                name: "IX_Professores_DisciplinaId",
                table: "Professores");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_SalaId",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Disciplinas");
        }
    }
}
