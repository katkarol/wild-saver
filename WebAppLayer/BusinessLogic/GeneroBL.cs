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
        public static void AdicionarGenero(Genero genero)
        {
            if (FamiliaDAL.Lista().Contains(genero.Familia))
            {
                throw new Exception("Familia Inválida!");
            }
            GeneroDAL.Adicionar(genero);
        }
    }
}