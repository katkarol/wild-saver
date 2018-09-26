using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
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
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Noticia noticia)
        {
            try
            {
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {

              return View();

            }

        }
        public ActionResult Vizualizar()
        {
           


            return View();
        }


    }
}