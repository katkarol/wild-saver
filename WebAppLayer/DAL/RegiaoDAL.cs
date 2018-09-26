using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class RegiaoDAL: IDisposable
    {
        public RegiaoDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(Regiao r)
        {
            contexto.Regioes.Add(r);
            contexto.SaveChanges();
        }

        public void Atualizar(Regiao r)
        {
            contexto.Update(r);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Regiao> Lista()
        {
            return contexto.Regioes.ToList();
        }

        public void Remover(Regiao r)
        {
            contexto.Regioes.Remove(r);
            contexto.SaveChanges();

        }
    }
}