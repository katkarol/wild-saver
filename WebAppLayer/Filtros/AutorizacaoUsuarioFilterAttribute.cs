using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppLayer.Filtros
{
    public class AutorizacaoUsuarioFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuario = filterContext.HttpContext.Session["USUARIO"];
            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary(
                new { action = "Login", controller = "Usuario" }));

            }
        }
    }
}