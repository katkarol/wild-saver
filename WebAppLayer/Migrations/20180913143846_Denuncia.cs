using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class Denuncia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Denucias",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioID = table.Column<int>(nullable: true),
                    DataInsercao = table.Column<DateTime>(nullable: false),
                    DataDaDenuncia = table.Column<DateTime>(nullable: false),
                    LocalID = table.Column<int>(nullable: false),
                    AnimalID = table.Column<int>(nullable: false),
                    DescricaoAnimal = table.Column<string>(nullable: true),
                    Anonimo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denucias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Denucias_Animais_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animais",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Denucias_Enderecos_LocalID",
                        column: x => x.LocalID,
                        principalTable: "Enderecos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Denucias_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Denucias_AnimalID",
                table: "Denucias",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_Denucias_LocalID",
                table: "Denucias",
                column: "LocalID");

            migrationBuilder.CreateIndex(
                name: "IX_Denucias_UsuarioID",
                table: "Denucias",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Denucias");
        }
    }
}
