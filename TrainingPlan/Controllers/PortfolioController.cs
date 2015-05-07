using System.Web.Mvc;

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
            return View();
        }

        [Route("Portfolio/{courseName}/{courseModule?}", Name = "courseModule")]
        public ActionResult CourseModule(string courseName, string courseModule)
        {
            // Course Name
            if (!string.IsNullOrEmpty(courseName) && string.IsNullOrEmpty(courseModule))
            {
                courseName = CourseDetailsFolder + courseName.Replace("-", string.Empty);

                return View(courseName);
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