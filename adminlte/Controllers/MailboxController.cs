using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace adminlte.Controllers
{
    public class MailboxController : Controller
    {
        // GET: Mailbox
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Compose()
        {
            return View();
        }

        public ActionResult Mailbox()
        {
            return View();
        }

        public ActionResult ReadMail()
        {
            return View();
        }
    }
}