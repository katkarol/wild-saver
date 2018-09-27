using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.BusinessLogic;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.Filtros;


namespace WebAppLayer.Controllers
{
    [AutorizacaoFuncionarioFilter]
    public class OrdemController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ClasseDAL classeDAL = new ClasseDAL();
            IList<Classe> classes = classeDAL.Lista();
            ViewBag.Classes = classes;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Ordem ordem)
        {
            OrdemBL ordemBL = new OrdemBL();
            ordemBL.AdicionarOrdem(ordem);
            return RedirectToAction("Cadastrar", "Familia");
        }

    }
}