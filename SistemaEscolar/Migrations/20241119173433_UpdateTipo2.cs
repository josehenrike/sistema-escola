using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEscolar.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTipo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Disciplinas",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Disciplinas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Disciplinas");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "Disciplinas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Disciplinas",
                table: "Disciplinas",
                column: "Codigo");
        }
    }
}
