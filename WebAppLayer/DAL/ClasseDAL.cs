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
        private  WildSaverContext contexto;


        public  void Adicionar(Classe c)
        {
            contexto.Classes.Add(c);
            contexto.SaveChanges();
        }

        public  void Atualizar(Classe c)
        {
            contexto.Update(c);
            contexto.SaveChanges();

        }

        public  void Dispose()
        {
            contexto.Dispose();
        }

        public  IList<Classe> Lista()
        {
            return contexto.Classes.ToList();
        }

        public  void Remover(Classe c)
        {
            contexto.Classes.Remove(c);
            contexto.SaveChanges();

        }
    }
}