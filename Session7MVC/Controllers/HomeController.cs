using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session7MVC.Controllers
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

        public string SomeFunction()
        {
            return "<html><body><h1>Hi how are you?</h1></body></html>";
        }

        public ActionResult Contact(string sometext)
        {
            if(sometext == "john")
            {
                return new HttpNotFoundResult();
            }
            ViewBag.Message = sometext;

            return View();
        }
    }
}