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
        private FiloDAL filoDAL;
        private ClasseDAL classeDAL;
  
        public ClasseBL()
        {
            this.filoDAL = new FiloDAL();
            this.classeDAL = new ClasseDAL();
        }

        public void AdicionarClasse(Classe classe )
        {
            if (!filoDAL.Lista().Contains(classe.Filo))
            {
                throw new Exception("Filo inválido!");
            }
           
            classeDAL.Adicionar(classe);
        }
        public IList<Classe> Lista()
        {
            return classeDAL.Lista();
        }
    }
}