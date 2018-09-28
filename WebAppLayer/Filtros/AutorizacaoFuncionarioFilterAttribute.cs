using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebAppLayer.Models.Enums;
namespace WebAppLayer.Filtros
{
    public class AutorizacaoFuncionarioFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuario = filterContext.HttpContext.Session["USUARIO"];
            object papelUsuario = filterContext.HttpContext.Session["PAPELUSUARIO"];
            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary(
                new { action = "Login", controller = "Usuario" }));
                
            }
            else if ((PapelUsuario)papelUsuario == PapelUsuario.Usuario)
            {
                filterContext.Result = new RedirectToRouteResult(
               new RouteValueDictionary(
               new { action = "Erro", controller = "Home" }));

            }
        }
    }
}