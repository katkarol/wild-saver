using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class GeneroDAL : IDisposable
    {
        public GeneroDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Genero g)
        {
            contexto.Generos.Add(g);
            contexto.SaveChanges();
        }

        public static void Atualizar(Genero g)
        {
            contexto.Update(g);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Genero> Lista()
        {
            return contexto.Generos.ToList();
        }

        public static void Remover(Genero g)
        {
            contexto.Generos.Remove(g);
            contexto.SaveChanges();

        }
    }
}