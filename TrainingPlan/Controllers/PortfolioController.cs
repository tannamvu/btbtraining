using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingPlan.Controllers
{
    public class PortfolioController : Controller
    {
        //
        // GET: /Portfolio/
        public ActionResult TwoPageColumn()
        {
            return View();
        }

        public ActionResult ThreePageColumn()
        {
            return View();
        }

        public ActionResult FourPageColumn()
        {
            return View();
        }

        public ActionResult SingleColumn()
        {
            return View();
        }
	}
}