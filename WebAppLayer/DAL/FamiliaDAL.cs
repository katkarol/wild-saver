using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class FamiliaDAL
    {
        public FamiliaDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(Familia f)
        {
            contexto.Familias.Add(f);
            contexto.SaveChanges();
        }

        public void Atualizar(Familia f)
        {
            contexto.Update(f);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Familia> Lista()
        {
            return contexto.Familias.ToList();
        }

        public void Remover(Familia f)
        {
            contexto.Familias.Remove(f);
            contexto.SaveChanges();

        }
    }
}