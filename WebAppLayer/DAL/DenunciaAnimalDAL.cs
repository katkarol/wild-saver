using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class DenunciaAnimalDAL
    {
        public DenunciaAnimalDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(DenunciaAnimal d)
        {
            contexto.Denuncias.Add(d.);
            contexto.SaveChanges();
        }

        public void Atualizar(DenunciaAnimal d)
        {
            contexto.Update(d);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<DenunciaAnimal> Lista()
        {
            return contexto..ToList();
        }

        public void Remover(DenunciaAnimal d)
        {
            contexto.Denuncias.Remove(d);
            contexto.SaveChanges();

        }
    }
}