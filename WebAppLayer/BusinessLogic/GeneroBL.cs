using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;
using WebAppLayer.DAL;


namespace WebAppLayer.BusinessLogic
{
    public class GeneroBL
    {
        private GeneroDAL generoDAL;
        private FamiliaDAL familiaDAL;

        public GeneroBL()
        {
            this.generoDAL = new GeneroDAL();
            this.familiaDAL = new FamiliaDAL();
        }
        public  void AdicionarGenero(Genero genero)
        {
            if (familiaDAL.Lista().Contains(genero.Familia))
            {
                throw new Exception("Familia Inválida!");
            }
            generoDAL.Adicionar(genero);
        }
    }
}