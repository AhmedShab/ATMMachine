using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMMachine.Controllers
{
    public class HomeController : Controller
    {
        [MyLoggingFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.TheMessage = "Having a troble, send us a message";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks, we got your message";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASDFGH101";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);

            //return Json(new { name = "serial", value = serial },
            //    JsonRequestBehavior.AllowGet);

            return RedirectToAction("index");
        }
    }
}