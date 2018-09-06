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
    [Migration("20180820143117_Ordens")]
    partial class Ordens
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppLayer.Models.Classe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FiloID");

                    b.Property<string>("NomeCompleto");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.HasIndex("FiloID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("WebAppLayer.Models.Filo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCompleto");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.ToTable("Filos");
                });

            modelBuilder.Entity("WebAppLayer.Models.Ordem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClasseID");

                    b.Property<string>("NomeCompleto");

                    b.Property<string>("NomePopular");

                    b.HasKey("ID");

                    b.HasIndex("ClasseID");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("WebAppLayer.Models.Classe", b =>
                {
                    b.HasOne("WebAppLayer.Models.Filo", "Filo")
                        .WithMany()
                        .HasForeignKey("FiloID");
                });

            modelBuilder.Entity("WebAppLayer.Models.Ordem", b =>
                {
                    b.HasOne("WebAppLayer.Models.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseID");
                });
#pragma warning restore 612, 618
        }
    }
}
