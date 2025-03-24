using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekat.Models;

namespace Projekat.Controllers
{
    public class ProjekatController : Controller
    {
        // GET: Projekat
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kontakt()
        {
            return View();
        }
        public ActionResult Meni()
        {
            double[] cene = {100,50,75,75,85,90};
            ViewBag.Cene = cene;
            return View();
        }
        [HttpPost]
        public ActionResult Poruka(kupci clan)
        {
            return View("Poruka", clan);
        }
        public ActionResult Poruka()
        {
            return View();
        }
    }
}