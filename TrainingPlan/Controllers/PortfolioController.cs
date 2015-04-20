using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingPlan.Controllers
{


    public class PortfolioController : Controller
    {
        // Course Portfolio
        [Route("Portfolio", Name = "portfolio")]
        public ActionResult TwoPageColumn()
        {
            return View();
        }

        // Course Details
        [Route("Portfolio/{courseName}")]
        public ActionResult SingleColumn(string courseName)
        {
            courseName = courseName.Replace("-", string.Empty);

            return View(courseName);
        }

        public ActionResult CourseDetail()
        {
            return View();
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