using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "eTicket description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "eTicket contact page.";

            return View();
        }
    }
}