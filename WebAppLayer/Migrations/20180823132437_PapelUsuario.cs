using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class PapelUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PapelUsuario",
                table: "Pessoas");

            migrationBuilder.AddColumn<int>(
                name: "PapelUsuario",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PapelUsuario",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "PapelUsuario",
                table: "Pessoas",
                nullable: false,
                defaultValue: 0);
        }
    }
}
