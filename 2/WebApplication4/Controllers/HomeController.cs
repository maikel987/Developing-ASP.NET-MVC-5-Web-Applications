using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult GetAddition()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult GetAddition(Calculation calc)
        {

            return View("ShowAddition", calc);
        }
    }
}