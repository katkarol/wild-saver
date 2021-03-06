﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.Filtros;


namespace WebAppLayer.Controllers
{
    [AutorizacaoUsuarioFilter]
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AutorizacaoFuncionarioFilter]
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