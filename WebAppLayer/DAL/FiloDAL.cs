using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.DAL
{
    public class FiloDAL : IDisposable
    {
        public FiloDAL()
        {
            contexto = new WildSaverContext();
        }
        private WildSaverContext contexto;


        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}