using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_11._2_Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to GC Coffee";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Register = "Please fill the form to register!";

            return View();
        }

        public ActionResult AddUser(string firstname, string lastname)
        {
            ViewBag.Welcome = $"Welcome, {firstname} {lastname}!";
            return View();
        }
    }
}