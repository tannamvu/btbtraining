using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using TrainingPlan.Models;

namespace TrainingPlan.Controllers
{
    public class PortfolioController : Controller
    {
        private const string CourseDetailsFolder = "Courses/";
        private const string CourseModuleFolder = "CourseModules/";

        // Course Portfolio
        [Route("Portfolio", Name = "portfolio")]
        public ActionResult TwoPageColumn()
        {
            ViewBag.PortfolioIsActiveLink = "active";
            return View();
        }

        [Route("Portfolio/{courseName}/{courseModule?}", Name = "courseModule")]
        public ActionResult CourseModule(string courseName, string courseModule)
        {
            // Course Name
            if (!string.IsNullOrEmpty(courseName) && string.IsNullOrEmpty(courseModule))
            {
                var viewModel = new CourseViewModel();
                courseName = CourseDetailsFolder + courseName.Replace("-", string.Empty);

                // use this for downloading files
                //var courseFileNames = Directory.GetFiles(Server.MapPath("~/Content/" + courseName));
                //viewModel.Courses = courseFileNames.Select(t => t.Split('\\')).Select(split => split[split.Length - 1]).ToList();


                return View(courseName, viewModel);
            }

            // Course Module
            courseModule = CourseDetailsFolder + CourseModuleFolder + courseModule.Replace("-", string.Empty);

            return View(courseModule);
        }

        //public ActionResult ThreePageColumn()
        //{
        //    return View();
        //}

        //[Route("Portfolio", Name = "portfolio")]
        //public ActionResult FourPageColumn()
        //{
        //    return View();
        //}

        //public ActionResult SingleColumn()
        //{
        //    return View();
        //}
	}
}