using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class PessoaDAL : IDisposable
    {
        public PessoaDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Pessoa p)
        {
            contexto.Pessoas.Add(p);
            contexto.SaveChanges();
        }

        public static void Atualizar(Pessoa p)
        {
            contexto.Update(p);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Pessoa> Lista()
        {
            return contexto.Pessoas.ToList();
        }

        public static void Remover(Pessoa p)
        {
            contexto.Pessoas.Remove(p);
            contexto.SaveChanges();

        }
    }
}