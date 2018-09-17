using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.BusinessLogic
{
    public class ClasseBL
    {
        public static void ValidarCadastro(Classe classe )
        {
            IList<Filo> filos = FiloDAL.Lista();
            if (!filos.Contains(classe.Filo))
            {
                throw new Exception("Filo inválido!");
            }

            ClasseDAL.Adicionar(classe);
        }
    }
}