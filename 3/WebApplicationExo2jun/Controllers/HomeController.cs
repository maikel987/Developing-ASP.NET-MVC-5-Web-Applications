using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationExo2jun.Models;

namespace WebApplicationExo2jun.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyDBEntities db = new MyDBEntities();
            var rClient = (from c in db.Clients where c.name.EndsWith("r") select c).ToArray();
            List<ClientModel> cm = new List<ClientModel>();

            foreach (var item in rClient)
            {
                cm.Add(new ClientModel() { Name = item.name });
            }

            return View(cm);
        }
    }
}