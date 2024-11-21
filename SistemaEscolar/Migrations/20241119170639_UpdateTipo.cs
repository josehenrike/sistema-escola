using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEscolar.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Inicio",
                table: "Turmas",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Fim",
                table: "Turmas",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 150);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Inicio",
                table: "Turmas",
                type: "int",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Fim",
                table: "Turmas",
                type: "int",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5);
        }
    }
}
