using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var test = new HomeTest { Header = "Test Me" };

            ViewBag.Title = "Home Page";
            ViewBag.Test = test;

            return View();
        }

        public class HomeTest
        {
            public String Header { get; set; }
        }
    }
}
