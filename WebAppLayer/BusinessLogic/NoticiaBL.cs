using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.BusinessLogic
{
    public class NoticiaBL
    {
       private NoticiaDAL noticiaDAL;

        public NoticiaBL()
        {
            this.noticiaDAL = new NoticiaDAL();
        }
       public void AdicionarNoticia(Noticia n)
        {
          // n.DataPublicacao.ToShortTimeString
            noticiaDAL.Adicionar(n);
        }
    }
}