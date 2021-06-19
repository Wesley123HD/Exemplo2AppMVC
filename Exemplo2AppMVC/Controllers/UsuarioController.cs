using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exemplo2AppMVC.Models;
using System.Collections.ObjectModel;

namespace Exemplo2AppMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            var usuario = new Usuario();
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

    }
}