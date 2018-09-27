using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.BusinessLogic
{
    public class DenunciaBL
    {
        private DenunciaDAL denunciaDAL;

        public DenunciaBL()
        {
            this.denunciaDAL = new DenunciaDAL();
        }

        public void AdicionarDenuncia(Denuncia denuncia)
        {
            if (denuncia.DataDaDenuncia > DateTime.Now)
            {
                throw new Exception("Data inválida!");
            }
             


            denuncia.EstadoDenuncia = Models.Enums.EstadoDenuncia.Aberto;
            denuncia.DataInsercao = DateTime.Now;
            denunciaDAL.Adicionar(denuncia);

        }
    }
}