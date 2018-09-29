using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;
using WebAppLayer.Util;

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
        internal DbSet<Usuario> Usuarios { get; set; }
        internal DbSet<Pessoa> Pessoas { get; set; }
        internal DbSet<Regiao> Regioes { get; set; }
        internal DbSet<Animal> Animais { get; set; }
        internal DbSet<Denuncia> Denuncias { get; set; }
        internal DbSet<Noticia> Noticias { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalRegiao>().HasKey(ar => new { ar.AnimalId, ar.RegiaoId });
            modelBuilder.Entity<DenunciaAnimal>().HasKey(da => new { da.AnimalId, da.DenunciaId });
            modelBuilder.Entity<Pessoa>().Property<int>("UsuarioID");

            modelBuilder.Entity<Pessoa>().HasKey("UsuarioID");
            base.OnModelCreating(modelBuilder);

        }



        public WildSaverContext(DbContextOptions<WildSaverContext> options) : base(options)
        { }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Constants.WildSaverDbConnectionString);
            }
        }

        public WildSaverContext()
        {
        }
    }
}