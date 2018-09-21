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
        private OrdemDAL ordemDAL;
        private ClasseDAL classeDAL;

        public OrdemBL()
        {
            this.ordemDAL = new OrdemDAL();
            this.classeDAL = new ClasseDAL();
        }
        public  void AdicionarOrdem(Ordem ordem)
        {
            if (classeDAL.Lista().Contains(ordem.Classe))
            {
                throw new Exception("Classe inválida!");
            }
            ordemDAL.Adicionar(ordem);
        }
    }
}