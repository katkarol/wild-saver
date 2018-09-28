using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Filtros
{
    public class Mudanca_Navbar
    {
        public Mudanca_Navbar()
        {
        }
        private static object papelUsuario;
        public static bool VerificarUsuario()
        {
            papelUsuario = HttpContext.Current.Session["PAPELUSUARIO"];

            if (papelUsuario == null || (PapelUsuario) papelUsuario == PapelUsuario.Usuario)
            {
                return true;

            }
            return false;
        }
        public static bool VerificarFuncionario()
        {

            if (papelUsuario != null &&(PapelUsuario)papelUsuario != PapelUsuario.Usuario)
            {
                return true;

            }
            return false;

        }
    }
}