using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class FiloDAL : IDisposable
    {
        public FiloDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Filo f)
        {
            contexto.Filos.Add(f);
            contexto.SaveChanges();
        }

        public static void Atualizar(Filo f)
        {
            contexto.Update(f);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Filo> Lista()
        {
            return contexto.Filos.ToList();
        }

        public static void Remover(Filo f)
        {
            contexto.Filos.Remove(f);
            contexto.SaveChanges();

        }

    }
}