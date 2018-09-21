using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;
using WebAppLayer.DAL;

namespace WebAppLayer.BusinessLogic
{
    public class FamiliaBL
    {
        private OrdemDAL ordemDAL;
        private FamiliaDAL familiaDAL;

        public FamiliaBL()
        {
            this.ordemDAL = new OrdemDAL();
            this.familiaDAL = new FamiliaDAL();
        }

        public  void AdicionarFamilia(Familia familia)
        {
             
            if (!ordemDAL.Lista().Contains(familia.Ordem))
            {
                throw new Exception("Ordem inválida");
            }

            familiaDAL.Adicionar(familia);
        }
    }
}