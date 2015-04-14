using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingPlan.Services;

namespace TrainingPlan.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailService _emailService;

        public HomeController()
        {
            _emailService = new EmailService();                    
            ViewBag.IsActiveLink = string.Empty;
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
            _emailService.SendEmail("test subject from website", "test body from website");
            ViewBag.ContactUsIsActiveLink = "active";
            return View();
        }

        [HttpPost]
        public ActionResult EmailEnquiry()
        {
            return RedirectToAction("ContactUs");
        }
	}
}