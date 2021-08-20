using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string msg)
        {
            // TODO: Send message
            ViewBag.Message = "Thanks we go your message.";

            return View();
        }



        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "23adf43";

            if(letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            //return new HttpStatusCodeResult(403);
            return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
        }

    }
}