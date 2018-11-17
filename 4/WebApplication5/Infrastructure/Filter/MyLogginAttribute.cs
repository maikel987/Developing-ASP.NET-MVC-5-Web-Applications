using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Infrastructure.Filter
{
    public class MyLogginAttribute : FilterAttribute, IActionFilter
    {
        Actions actions = Actions.GetInstance();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{DateTime.Now}:   Controller: {filterContext.ActionDescriptor.ControllerDescriptor.ControllerName}, Action: {filterContext.ActionDescriptor.ActionName}, Parameters: num=");
            if(filterContext.RouteData.Values["id"]!=null)sb.Append(filterContext.RouteData.Values["id"].ToString());


            //if (filterContext.ActionDescriptor.GetParameters() != null)
            //{
            //    sb.Append(", Parameters: ");
            //    foreach (var item in filterContext.ActionDescriptor.GetParameters())
            //    {
            //        sb.Append($"{ item.ToString()}");
            //    }
            //}

            actions.actionList.Add(sb.ToString());
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"{DateTime.Now}   {filterContext.Controller.ControllerContext.ToString()} {filterContext.ActionDescriptor.ActionName}  {filterContext.ActionDescriptor.GetParameters().ToString()}");
            //string strTmp = sb.ToString();
            //actions.actionList.Add(strTmp);
        }
    }
}