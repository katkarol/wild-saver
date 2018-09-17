using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class EnderecoDAL : IDisposable
    {
        public EnderecoDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Endereco e)
        {
            contexto.Enderecos.Add(e);
            contexto.SaveChanges();
        }

        public static void Atualizar(Endereco e)
        {
            contexto.Update(e);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Endereco> Lista()
        {
            return contexto.Enderecos.ToList();
        }

        public static void Remover(Endereco e)
        {
            contexto.Enderecos.Remove(e);
            contexto.SaveChanges();

        }
    }
}