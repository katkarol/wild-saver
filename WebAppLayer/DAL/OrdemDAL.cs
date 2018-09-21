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
        private  WildSaverContext contexto;


        public  void Adicionar(Ordem o)
        {
            contexto.Ordens.Add(o);
            contexto.SaveChanges();
        }

        public  void Atualizar(Ordem o)
        {
            contexto.Update(o);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public  IList<Ordem> Lista()
        {
            return contexto.Ordens.ToList();
        }

        public  void Remover(Ordem o)
        {
            contexto.Ordens.Remove(o);
            contexto.SaveChanges();

        }
    }
}