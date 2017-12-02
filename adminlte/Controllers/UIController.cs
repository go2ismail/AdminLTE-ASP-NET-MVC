using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminlte.Controllers
{
    public class UIController : Controller
    {
        // GET: UI
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult General()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Modals()
        {
            return View();
        }       

        public ActionResult Timeline()
        {
            return View();
        }
    }
}