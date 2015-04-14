using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingPlan.Models;
using TrainingPlan.Services;

namespace TrainingPlan.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
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
            ViewBag.ContactUsIsActiveLink = "active";
            return View();
        }

        [HttpPost]
        public ActionResult EmailEnquiry(ContactUsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var body = string.Format("Name: {1}{0}{0} Email: {2}{0}{0} Message:{3}", Environment.NewLine, viewModel.Name, viewModel.Email, viewModel.Message);

                EmailService.SendEmail(viewModel.Subject, body);
            }

            return RedirectToAction("ContactUs");
        }
	}
}