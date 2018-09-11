using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class PessoaDAL
    {
        public PessoaDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(Pessoa p)
        {
            contexto.Pessoas.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(Pessoa p)
        {
            contexto.Update(p);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public IList<Pessoa> Lista()
        {
            return contexto.Pessoas.ToList();
        }

        public void Remover(Pessoa p)
        {
            contexto.Pessoas.Remove(p);
            contexto.SaveChanges();

        }
    }
}