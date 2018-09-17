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
        public static void AdicionarFamilia(Familia familia)
        {
            if (!OrdemDAL.Lista().Contains(familia.Ordem))
            {
                throw new Exception("Ordem inválida");
            }

            FamiliaDAL.Adicionar(familia);
        }
    }
}