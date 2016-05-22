﻿using System;
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

        [Route("Services", Name = "services")]
        public ActionResult Services()
        {
            ViewBag.ServicesIsActiveLink = "active";
            return View();
        }

        [Route("AboutUs", Name = "aboutUs")]
        public ActionResult AboutUs()
        {
            ViewBag.AboutUsIsActiveLink = "active";
            return View();
        }

        [Route("WhoWeWorkWith", Name = "whoWeWorkWith")]
        public ActionResult WhoWeWorkWith()
        {
            ViewBag.WhoWeWorkWithIsActiveLink = "active";
            return View();
        }

        [Route("ContactUs", Name = "contactUs")]
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
                var body = string.Format("Name: {1}{0}{0} Company Name: {2}{0}{0} Contact Number: {3}{0}{0} Email: {4}{0}{0} Message:{5}", Environment.NewLine, viewModel.Name, viewModel.CompanyName, viewModel.ContactNumber, viewModel.Email, viewModel.Message);

                EmailService.SendEmail(viewModel.Subject, body);
            }

            return RedirectToAction("ContactUs");
        }
	}
}