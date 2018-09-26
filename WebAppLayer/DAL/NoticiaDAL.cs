using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class NoticiaDAL : IDisposable
    {
        public NoticiaDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Adicionar(Noticia n)
        {
            contexto.Noticias.Add(n);
            contexto.SaveChanges();
        }

        public void Atualizar(Noticia n)
        {
            contexto.Update(n);
            contexto.SaveChanges();

        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public List<Noticia> Lista()
        {
            return contexto.Noticias.ToList();
        }

        public void Remover(Noticia n)
        {
            contexto.Noticias.Remove(n);
            contexto.SaveChanges();

        }
    }
}