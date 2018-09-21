using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class DenunciaDAL
    {
        public DenunciaDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(Denuncia d)
        {
            contexto.Denuncias.Add(d);
            contexto.SaveChanges();
        }

        public void Atualizar(Denuncia d)
        {
            contexto.Update(d);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Denuncia> Lista()
        {
            return contexto.Denuncias.ToList();
        }

        public void Remover(Denuncia d)
        {
            contexto.Denuncias.Remove(d);
            contexto.SaveChanges();

        }
    }
}