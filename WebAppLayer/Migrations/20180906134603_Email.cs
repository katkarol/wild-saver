using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppLayer.Migrations
{
    public partial class Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Filos_FiloID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Familias_Ordens_OrdemID",
                table: "Familias");

            migrationBuilder.DropForeignKey(
                name: "FK_Generos_Familias_FamiliaID",
                table: "Generos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Classes_ClasseID",
                table: "Ordens");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoID",
                table: "Pessoas");

           

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompleto",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoID",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Ordens",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClasseID",
                table: "Ordens",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Ordens",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Generos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FamiliaID",
                table: "Generos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Generos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Filos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Filos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OrdemID",
                table: "Familias",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Familias",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Familias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Enderecos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Classes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FiloID",
                table: "Classes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Classes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Filos_FiloID",
                table: "Classes",
                column: "FiloID",
                principalTable: "Filos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Familias_Ordens_OrdemID",
                table: "Familias",
                column: "OrdemID",
                principalTable: "Ordens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_Familias_FamiliaID",
                table: "Generos",
                column: "FamiliaID",
                principalTable: "Familias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Classes_ClasseID",
                table: "Ordens",
                column: "ClasseID",
                principalTable: "Classes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoID",
                table: "Pessoas",
                column: "EnderecoID",
                principalTable: "Enderecos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Filos_FiloID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Familias_Ordens_OrdemID",
                table: "Familias");

            migrationBuilder.DropForeignKey(
                name: "FK_Generos_Familias_FamiliaID",
                table: "Generos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordens_Classes_ClasseID",
                table: "Ordens");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoID",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Ordens");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Filos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Familias");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Classes");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomeCompleto",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoID",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Ordens",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ClasseID",
                table: "Ordens",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "Ordens",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Generos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "FamiliaID",
                table: "Generos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "Generos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Filos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "Filos",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrdemID",
                table: "Familias",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Familias",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "Familias",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomePopular",
                table: "Classes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "FiloID",
                table: "Classes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Filos_FiloID",
                table: "Classes",
                column: "FiloID",
                principalTable: "Filos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Familias_Ordens_OrdemID",
                table: "Familias",
                column: "OrdemID",
                principalTable: "Ordens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_Familias_FamiliaID",
                table: "Generos",
                column: "FamiliaID",
                principalTable: "Familias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordens_Classes_ClasseID",
                table: "Ordens",
                column: "ClasseID",
                principalTable: "Classes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoID",
                table: "Pessoas",
                column: "EnderecoID",
                principalTable: "Enderecos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
