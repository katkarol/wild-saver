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
        private  WildSaverContext contexto;


        public  void Adicionar(Endereco e)
        {
            contexto.Enderecos.Add(e);
            contexto.SaveChanges();
        }

        public  void Atualizar(Endereco e)
        {
            contexto.Update(e);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public  IList<Endereco> Lista()
        {
            return contexto.Enderecos.ToList();
        }

        public  void Remover(Endereco e)
        {
            contexto.Enderecos.Remove(e);
            contexto.SaveChanges();

        }
    }
}