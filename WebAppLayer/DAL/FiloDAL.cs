using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class FiloDAL
    {
        public FiloDAL()
        {
            contexto = new WildSaverContext();
        }
        private  WildSaverContext contexto;


        public  void Adicionar(Filo f)
        {
            contexto.Filos.Add(f);
            contexto.SaveChanges();
        }

        public  void Atualizar(Filo f)
        {
            contexto.Update(f);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public  IList<Filo> Lista()
        {
            return contexto.Filos.ToList();
        }

        public  void Remover(Filo f)
        {
            contexto.Filos.Remove(f);
            contexto.SaveChanges();

        }

    }
}