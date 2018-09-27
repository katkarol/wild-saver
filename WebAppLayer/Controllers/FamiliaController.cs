using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.BusinessLogic;
using WebAppLayer.Filtros;


namespace WebAppLayer.Controllers
{
    [AutorizacaoFuncionarioFilter]
    public class FamiliaController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            OrdemDAL ordemDAL = new OrdemDAL();
            IList<Ordem> ordens = ordemDAL.Lista();
            ViewBag.Ordens = ordens;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Familia familia)
        {
            FamiliaBL familiaBL = new FamiliaBL();
            familiaBL.AdicionarFamilia(familia);
            return RedirectToAction("Cadastrar", "Genero");

        }
    }
}