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
            contexto.DenunciaAnimal.Add(d);
            contexto.SaveChanges();
        }

        public void AdicionarAnimal(Denuncia d, Animal a)
        {
            var denunciaAnimal = new DenunciaAnimal();
            denunciaAnimal.Animal = a;
            denunciaAnimal.Denuncia = d;
            contexto.DenunciaAnimal.Add(denunciaAnimal);
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
            return contexto.DenunciaAnimal.ToList();
        }
        public IList<DenunciaAnimal> Lista(Denuncia d)
        {
            return contexto.DenunciaAnimal.Where(x => x.Denuncia == d).ToList();
        }
        public IList<Animal> Lista2(Denuncia d)
        {
            return contexto.DenunciaAnimal.Where(x => x.Denuncia == d).Select(x => x.Animal).ToList();
        }
        public void Remover(DenunciaAnimal d)
        {
            contexto.DenunciaAnimal.Remove(d);
            contexto.SaveChanges();

        }
    }
}