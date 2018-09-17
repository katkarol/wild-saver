using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class ClasseDAL : IDisposable
    {
        public ClasseDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Classe c)
        {
            contexto.Classes.Add(c);
            contexto.SaveChanges();
        }

        public static void Atualizar(Classe c)
        {
            contexto.Update(c);
            contexto.SaveChanges();

        }

        public  void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Classe> Lista()
        {
            return contexto.Classes.ToList();
        }

        public static void Remover(Classe c)
        {
            contexto.Classes.Remove(c);
            contexto.SaveChanges();

        }
    }
}