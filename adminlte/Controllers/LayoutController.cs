using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminlte.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Boxed()
        {
            return View();
        }

        public ActionResult CollapsedSidebar()
        {
            return View();
        }

        public ActionResult Fixed()
        {
            return View();
        }

        public ActionResult TopNav()
        {
            return View();
        }
    }
}