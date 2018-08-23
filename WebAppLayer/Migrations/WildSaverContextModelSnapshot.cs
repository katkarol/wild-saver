﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppLayer.DAL;

namespace WebAppLayer.Migrations
{
    [DbContext(typeof(WildSaverContext))]
    partial class WildSaverContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppLayer.Models.Classe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FiloID");

                    b.Property<string>("Nome");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.HasIndex("FiloID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("WebAppLayer.Models.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("CEP");

                    b.Property<string>("Cidade");

                    b.Property<string>("Pais");

                    b.Property<string>("Rua");

                    b.Property<string>("UF");

                    b.HasKey("ID");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Familia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<string>("NomePopular");

                    b.Property<int?>("OrdemID");

                    b.HasKey("ID");

                    b.HasIndex("OrdemID");

                    b.ToTable("Familias");
                });

            modelBuilder.Entity("WebAppLayer.Models.Filo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.ToTable("Filos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Genero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FamiliaID");

                    b.Property<string>("Nome");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.HasIndex("FamiliaID");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Ordem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClasseID");

                    b.Property<string>("Nome");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.HasIndex("ClasseID");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("WebAppLayer.Models.Pessoa", b =>
                {
                    b.Property<int>("UsuarioID");

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int?>("EnderecoID");

                    b.Property<string>("Nome");

                    b.HasKey("UsuarioID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("WebAppLayer.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login");

                    b.Property<int>("PapelUsuario");

                    b.Property<string>("Senha");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebAppLayer.Models.Classe", b =>
                {
                    b.HasOne("WebAppLayer.Models.Filo", "Filo")
                        .WithMany()
                        .HasForeignKey("FiloID");
                });

            modelBuilder.Entity("WebAppLayer.Models.Familia", b =>
                {
                    b.HasOne("WebAppLayer.Models.Ordem", "Ordem")
                        .WithMany()
                        .HasForeignKey("OrdemID");
                });

            modelBuilder.Entity("WebAppLayer.Models.Genero", b =>
                {
                    b.HasOne("WebAppLayer.Models.Familia", "Familia")
                        .WithMany()
                        .HasForeignKey("FamiliaID");
                });

            modelBuilder.Entity("WebAppLayer.Models.Ordem", b =>
                {
                    b.HasOne("WebAppLayer.Models.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseID");
                });

            modelBuilder.Entity("WebAppLayer.Models.Pessoa", b =>
                {
                    b.HasOne("WebAppLayer.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID");

                    b.HasOne("WebAppLayer.Models.Usuario")
                        .WithOne("PessoaUsuaria")
                        .HasForeignKey("WebAppLayer.Models.Pessoa", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
