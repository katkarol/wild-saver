using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class WildSaverContext : DbContext
    {
        internal DbSet<Filo> Filos { get; set; }
        internal DbSet<Classe> Classes { get; set; }
        internal DbSet<Ordem> Ordens { get; set; }
        internal DbSet<Familia> Familias { get; set; }
        internal DbSet<Genero> Generos { get; set; }
        internal DbSet<Endereco> Enderecos { get; set; }


        public WildSaverContext(DbContextOptions<WildSaverContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoas");

            modelBuilder.Entity<Pessoa>().Property<int>("UsuarioID");

            modelBuilder.Entity<Pessoa>().HasKey("UsuarioID");
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=WildSaverDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            }
        }

        public WildSaverContext()
        {
        }
    }
}