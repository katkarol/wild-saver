using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class estadodenuncia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalID",
                table: "Regioes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoDenuncia",
                table: "Denucias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regioes_AnimalID",
                table: "Regioes",
                column: "AnimalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Regioes_Animais_AnimalID",
                table: "Regioes",
                column: "AnimalID",
                principalTable: "Animais",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regioes_Animais_AnimalID",
                table: "Regioes");

            migrationBuilder.DropIndex(
                name: "IX_Regioes_AnimalID",
                table: "Regioes");

            migrationBuilder.DropColumn(
                name: "AnimalID",
                table: "Regioes");

            migrationBuilder.DropColumn(
                name: "EstadoDenuncia",
                table: "Denucias");
        }
    }
}
