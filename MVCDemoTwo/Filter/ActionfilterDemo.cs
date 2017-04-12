using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoTwo.Filter
{
    public class ActionfilterDemo : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            filterContext.HttpContext.Response.Write("开始时间:" + DateTime.Now.ToString() + "<br/>");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            var controllerName = filterContext.RouteData.Values["controller"].ToString();
            var actionName = filterContext.RouteData.Values["action"].ToString();

            filterContext.HttpContext.Response.Write("结束时间:" + DateTime.Now.ToString() + "<br/>");
            filterContext.HttpContext.Response.Write("controller:" + controllerName + ",action:" + actionName);
        }
    }
}