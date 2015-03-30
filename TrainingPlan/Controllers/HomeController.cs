using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingPlan.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            @ViewBag.IsActiveLink = string.Empty;
        }
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.HomeIsActiveLink = "active";
            ViewBag.Title = "BTB Training";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.ServicesIsActiveLink = "active";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.AboutUsIsActiveLink = "active";
            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.ContactUsIsActiveLink = "active";
            return View();
        }
	}
}