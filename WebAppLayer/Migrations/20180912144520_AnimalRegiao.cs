using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class AnimalRegiao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Regioes_RegiaoID",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_RegiaoID",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "RegiaoID",
                table: "Animais");

            migrationBuilder.CreateTable(
                name: "AnimalRegiao",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false),
                    RegiaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRegiao", x => new { x.AnimalId, x.RegiaoId });
                    table.ForeignKey(
                        name: "FK_AnimalRegiao_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalRegiao_Regioes_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regioes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRegiao_RegiaoId",
                table: "AnimalRegiao",
                column: "RegiaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalRegiao");

            migrationBuilder.AddColumn<int>(
                name: "RegiaoID",
                table: "Animais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animais_RegiaoID",
                table: "Animais",
                column: "RegiaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Regioes_RegiaoID",
                table: "Animais",
                column: "RegiaoID",
                principalTable: "Regioes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
