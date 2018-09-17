using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;
using WebAppLayer.DAL;

namespace WebAppLayer.BusinessLogic
{
    public class OrdemBL
    {
        public static void AdicionarOrdem(Ordem ordem)
        {
            if (ClasseDAL.Lista().Contains(ordem.Classe))
            {
                throw new Exception("Classe inválida!");
            }
            OrdemDAL.Adicionar(ordem);
        }
    }
}