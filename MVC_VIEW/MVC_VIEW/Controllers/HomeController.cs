using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_VIEW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            TempData["Cities"] = new List<string>()
            {
                "Karachi","Islamabad","Multan","Peshawar"
            };


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewData["Cities"] = new List<string>()
            {
                "Karachi","Islamabad","Multan","Peshawar"
            };

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Cities = new List<string>()
            {
                "Karachi","Islamabad","Multan","Peshawar"
            };
            return View();
        }
    }
}