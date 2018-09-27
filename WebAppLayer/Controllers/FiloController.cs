using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.BusinessLogic;
using WebAppLayer.Models;
using WebAppLayer.Filtros;

namespace WebAppLayer.Controllers
{
    [AutorizacaoFuncionarioFilter]
    public class FiloController : Controller
    {
      
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Filo filo)
        {
            try
            {
                ViewBag.Erro = "";
                FiloBL filobl = new FiloBL();
                filobl.AdicionarFilo(filo);
                return RedirectToAction("Cadastrar", "Classe");

            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View(filo);
            }

        }
    }
}