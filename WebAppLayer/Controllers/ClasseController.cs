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
    [AutorizacaoFuncionarioFilterAttribute]
    public class ClasseController : Controller
    { 
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ClasseBL classeBL = new ClasseBL();
            FiloDAL filoDAL = new FiloDAL();

            IList<Filo> filos = filoDAL.Lista();
            ViewBag.Filos = filos;
            ViewBag.Classes = classeBL.Lista();

            return View(new Classe());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Classe classe)
        {
            ClasseBL classeBL = new ClasseBL();
            try
            {
                ViewBag.Erro = "";
                classeBL.AdicionarClasse(classe);
                return RedirectToAction("Cadastrar", "Ordem");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View(classe);
            }
            
        }

    }
}