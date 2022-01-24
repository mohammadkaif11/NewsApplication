using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is index";
            return View();
        }

        public ActionResult Sport()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Entertainment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Technology()
        {
            return View();
        }
    }
}