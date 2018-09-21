using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class AnimalDAL
    {
        public AnimalDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(Animal a)
        {
            contexto.Animais.Add(a);
            contexto.SaveChanges();
        }

        public void Atualizar(Animal a)
        {
            contexto.Update(a);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Animal> Lista()
        {
            return contexto.Animais.ToList();
        }

        public void Remover(Animal a)
        {
            contexto.Animais.Remove(a);
            contexto.SaveChanges();

        }
    }
}