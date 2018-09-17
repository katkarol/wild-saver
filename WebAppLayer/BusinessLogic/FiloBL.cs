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
        public static void AdicionarFilo(Filo filo)
        {
            FiloDAL.Adicionar(filo);
        }
    }
}