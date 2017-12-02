using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminlte.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chartjs()
        {
            return View();
        }

        public ActionResult Flot()
        {
            return View();
        }

        public ActionResult Inline()
        {
            return View();
        }

        public ActionResult Morris()
        {
            return View();
        }
    }
}