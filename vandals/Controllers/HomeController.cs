using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using vandals.Models;

namespace vandals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GraffitiRepository graffitiRepository = new GraffitiRepository();
            List<Graffiti> graffitis = new List<Graffiti>();
            graffitis = graffitiRepository.GetGraffitis();
            ViewBag.Array = graffitis;
            return View();
        }
    }
}