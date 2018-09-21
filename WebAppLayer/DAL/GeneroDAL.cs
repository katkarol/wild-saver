using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class GeneroDAL : IDisposable
    {
        public GeneroDAL()
        {
            contexto = new WildSaverContext();
        }
        private  WildSaverContext contexto;


        public  void Adicionar(Genero g)
        {
            contexto.Generos.Add(g);
            contexto.SaveChanges();
        }

        public  void Atualizar(Genero g)
        {
            contexto.Update(g);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public  IList<Genero> Lista()
        {
            return contexto.Generos.ToList();
        }

        public  void Remover(Genero g)
        {
            contexto.Generos.Remove(g);
            contexto.SaveChanges();

        }
    }
}