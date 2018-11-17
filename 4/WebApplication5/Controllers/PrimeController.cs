using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class PrimeController : Controller
    {
        Actions tmp = Actions.GetInstance();


        // GET: Prime
        [Infrastructure.Filter.MyLoggin]
        public ActionResult Calc()
        {


            //sb.Append($"{DateTime.Now} Controler: {ControllerContext.Controller.ValueProvider.ToString()} ");
            ////    sb.Append($"{ViewBag.Tostring()} ");
            //sb.Append($"{HttpContext.User.Identity.ToString()} ");
            ////sb.Append($" Action: {ControllerContext.ParentActionViewContext.RouteData.Values} ");
            ////sb.Append($"{ViewData.Model.ToString()} ");
            //sb.Append($"{ViewData.Values.ToString()}   ");

            return View(tmp);
        }

        public ActionResult AllAction()
        {
            return View(tmp);
        }
    }
}