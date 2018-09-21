using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class denuncias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Denucias_Enderecos_LocalID",
                table: "Denucias");

            migrationBuilder.DropForeignKey(
                name: "FK_Denucias_Usuarios_UsuarioID",
                table: "Denucias");

            migrationBuilder.DropForeignKey(
                name: "FK_DenunciaAnimal_Denucias_DenunciaId",
                table: "DenunciaAnimal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Denucias",
                table: "Denucias");

            migrationBuilder.RenameTable(
                name: "Denucias",
                newName: "Denuncias");

            migrationBuilder.RenameIndex(
                name: "IX_Denucias_UsuarioID",
                table: "Denuncias",
                newName: "IX_Denuncias_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Denucias_LocalID",
                table: "Denuncias",
                newName: "IX_Denuncias_LocalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Denuncias",
                table: "Denuncias",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DenunciaAnimal_Denuncias_DenunciaId",
                table: "DenunciaAnimal",
                column: "DenunciaId",
                principalTable: "Denuncias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Denuncias_Enderecos_LocalID",
                table: "Denuncias",
                column: "LocalID",
                principalTable: "Enderecos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Denuncias_Usuarios_UsuarioID",
                table: "Denuncias",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DenunciaAnimal_Denuncias_DenunciaId",
                table: "DenunciaAnimal");

            migrationBuilder.DropForeignKey(
                name: "FK_Denuncias_Enderecos_LocalID",
                table: "Denuncias");

            migrationBuilder.DropForeignKey(
                name: "FK_Denuncias_Usuarios_UsuarioID",
                table: "Denuncias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Denuncias",
                table: "Denuncias");

            migrationBuilder.RenameTable(
                name: "Denuncias",
                newName: "Denucias");

            migrationBuilder.RenameIndex(
                name: "IX_Denuncias_UsuarioID",
                table: "Denucias",
                newName: "IX_Denucias_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Denuncias_LocalID",
                table: "Denucias",
                newName: "IX_Denucias_LocalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Denucias",
                table: "Denucias",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Denucias_Enderecos_LocalID",
                table: "Denucias",
                column: "LocalID",
                principalTable: "Enderecos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Denucias_Usuarios_UsuarioID",
                table: "Denucias",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DenunciaAnimal_Denucias_DenunciaId",
                table: "DenunciaAnimal",
                column: "DenunciaId",
                principalTable: "Denucias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
