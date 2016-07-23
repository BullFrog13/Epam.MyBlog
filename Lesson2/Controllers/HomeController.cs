using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson2.Models;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration(string name, string age, string gender, string email,
                                        string telephone, string notification, string password,
                                        string remember)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Gender = gender;
            ViewBag.Email = email;
            ViewBag.Telephone = telephone;
            ViewBag.Notification = notification;
            ViewBag.Password = password;
            ViewBag.Remember = remember;
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult GuestPage()
        {
            return View();
        }
    }
}