using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class DenuciaAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Denucias_Animais_AnimalID",
                table: "Denucias");

            migrationBuilder.DropIndex(
                name: "IX_Denucias_AnimalID",
                table: "Denucias");

            migrationBuilder.DropColumn(
                name: "AnimalID",
                table: "Denucias");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoAnimal",
                table: "Denucias",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DenunciaAnimal",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false),
                    DenunciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DenunciaAnimal", x => new { x.AnimalId, x.DenunciaId });
                    table.ForeignKey(
                        name: "FK_DenunciaAnimal_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DenunciaAnimal_Denucias_DenunciaId",
                        column: x => x.DenunciaId,
                        principalTable: "Denucias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DenunciaAnimal_DenunciaId",
                table: "DenunciaAnimal",
                column: "DenunciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DenunciaAnimal");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoAnimal",
                table: "Denucias",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AnimalID",
                table: "Denucias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Denucias_AnimalID",
                table: "Denucias",
                column: "AnimalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Denucias_Animais_AnimalID",
                table: "Denucias",
                column: "AnimalID",
                principalTable: "Animais",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
