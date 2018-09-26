﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppLayer.DAL;

namespace WebAppLayer.Migrations
{
    [DbContext(typeof(WildSaverContext))]
    [Migration("20180926144519_noticias")]
    partial class noticias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppLayer.Models.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("GeneroID");

                    b.Property<string>("NomePopular")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("GeneroID");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("WebAppLayer.Models.AnimalRegiao", b =>
                {
                    b.Property<int>("AnimalId");

                    b.Property<int>("RegiaoId");

                    b.HasKey("AnimalId", "RegiaoId");

                    b.HasIndex("RegiaoId");

                    b.ToTable("AnimalRegiao");
                });

            modelBuilder.Entity("WebAppLayer.Models.Classe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FiloID");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomePopular")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("FiloID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("WebAppLayer.Models.Denuncia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Anonimo");

                    b.Property<DateTime>("DataDaDenuncia");

                    b.Property<DateTime>("DataInsercao");

                    b.Property<string>("DescricaoAnimal")
                        .IsRequired();

                    b.Property<int>("EstadoDenuncia");

                    b.Property<int>("LocalID");

                    b.Property<int?>("UsuarioID");

                    b.HasKey("ID");

                    b.HasIndex("LocalID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Denuncias");
                });

            modelBuilder.Entity("WebAppLayer.Models.DenunciaAnimal", b =>
                {
                    b.Property<int>("AnimalId");

                    b.Property<int>("DenunciaId");

                    b.HasKey("AnimalId", "DenunciaId");

                    b.HasIndex("DenunciaId");

                    b.ToTable("DenunciaAnimal");
                });

            modelBuilder.Entity("WebAppLayer.Models.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("CEP")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired();

                    b.Property<string>("Rua")
                        .IsRequired();

                    b.Property<string>("UF")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Familia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomePopular")
                        .IsRequired();

                    b.Property<int>("OrdemID");

                    b.HasKey("ID");

                    b.HasIndex("OrdemID");

                    b.ToTable("Familias");
                });

            modelBuilder.Entity("WebAppLayer.Models.Filo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomePopular")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Filos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Genero", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FamiliaID");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomePopular")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("FamiliaID");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Noticia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<string>("Resumo")
                        .IsRequired();

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("WebAppLayer.Models.Ordem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClasseID");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NomePopular")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ClasseID");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("WebAppLayer.Models.Pessoa", b =>
                {
                    b.Property<int>("UsuarioID");

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("EnderecoID");

                    b.Property<string>("NomeCompleto")
                        .IsRequired();

                    b.HasKey("UsuarioID");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("WebAppLayer.Models.Regiao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalID");

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("Pais")
                        .IsRequired();

                    b.Property<string>("UF")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("AnimalID");

                    b.ToTable("Regioes");
                });

            modelBuilder.Entity("WebAppLayer.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<int>("PapelUsuario");

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebAppLayer.Models.Animal", b =>
                {
                    b.HasOne("WebAppLayer.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.AnimalRegiao", b =>
                {
                    b.HasOne("WebAppLayer.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppLayer.Models.Regiao", "Regiao")
                        .WithMany()
                        .HasForeignKey("RegiaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Classe", b =>
                {
                    b.HasOne("WebAppLayer.Models.Filo", "Filo")
                        .WithMany()
                        .HasForeignKey("FiloID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Denuncia", b =>
                {
                    b.HasOne("WebAppLayer.Models.Endereco", "Local")
                        .WithMany()
                        .HasForeignKey("LocalID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppLayer.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");
                });

            modelBuilder.Entity("WebAppLayer.Models.DenunciaAnimal", b =>
                {
                    b.HasOne("WebAppLayer.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppLayer.Models.Denuncia", "Denuncia")
                        .WithMany()
                        .HasForeignKey("DenunciaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Familia", b =>
                {
                    b.HasOne("WebAppLayer.Models.Ordem", "Ordem")
                        .WithMany()
                        .HasForeignKey("OrdemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Genero", b =>
                {
                    b.HasOne("WebAppLayer.Models.Familia", "Familia")
                        .WithMany()
                        .HasForeignKey("FamiliaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Ordem", b =>
                {
                    b.HasOne("WebAppLayer.Models.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Pessoa", b =>
                {
                    b.HasOne("WebAppLayer.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppLayer.Models.Usuario")
                        .WithOne("PessoaUsuaria")
                        .HasForeignKey("WebAppLayer.Models.Pessoa", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAppLayer.Models.Regiao", b =>
                {
                    b.HasOne("WebAppLayer.Models.Animal")
                        .WithMany("Regioes")
                        .HasForeignKey("AnimalID");
                });
#pragma warning restore 612, 618
        }
    }
}
