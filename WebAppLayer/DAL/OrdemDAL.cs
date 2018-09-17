using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class OrdemDAL : IDisposable
    {
        public OrdemDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Ordem o)
        {
            contexto.Ordens.Add(o);
            contexto.SaveChanges();
        }

        public static void Atualizar(Ordem o)
        {
            contexto.Update(o);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Ordem> Lista()
        {
            return contexto.Ordens.ToList();
        }

        public static void Remover(Ordem o)
        {
            contexto.Ordens.Remove(o);
            contexto.SaveChanges();

        }
    }
}