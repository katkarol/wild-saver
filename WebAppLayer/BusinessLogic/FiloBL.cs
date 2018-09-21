using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.BusinessLogic
{
    public class FiloBL
    {
        private FiloDAL filoDAL;

        public FiloBL()
        {
            this.filoDAL = new FiloDAL();
        }
        public  void AdicionarFilo(Filo filo)
        {
            filoDAL.Adicionar(filo);
        }
    }
}