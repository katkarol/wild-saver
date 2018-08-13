using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class DenunciaController : Controller
    {
        // GET: Denuncia
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Denuncia denuncia)
        {
            return View();
        } 
    }
}