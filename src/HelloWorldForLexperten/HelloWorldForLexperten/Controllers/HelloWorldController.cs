using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldForLexperten.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult Detail()
        {
            //if(DateTime.Today.DayOfWeek == DayOfWeek.Monday) 
            //{
            //    return new RedirectResult("/");
            //};

            //return Content("Hello World from the Hello World For Lexperten Controller!");

            return View();
        }
    }
}
