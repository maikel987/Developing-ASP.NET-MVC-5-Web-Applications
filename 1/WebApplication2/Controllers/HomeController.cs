using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPersonDetails()
        {
            Person maik = new Person() { Name = "Maikel", City = "Tel Aviv" };
            return View(maik);
        }
    }
}