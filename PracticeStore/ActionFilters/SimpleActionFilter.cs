using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeStore.ActionFilters
{
    public class SimpleActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine(filterContext.RouteData.Values);
            Debug.WriteLine(filterContext.HttpContext.Request);
            Debug.WriteLine(filterContext.Controller);
            Debug.WriteLine(filterContext.Result);
            Debug.WriteLine("This Event Fired: OnActionExecuting ");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine(filterContext.RouteData.Values);
            Debug.WriteLine(filterContext.HttpContext);
            Debug.WriteLine(filterContext.Controller);
            Debug.WriteLine(filterContext.Result);
            Debug.WriteLine("This Event Fired: OnActionExecuted ");
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine(filterContext.RouteData.Values);
            Debug.WriteLine(filterContext.HttpContext);
            Debug.WriteLine(filterContext.Controller);
            Debug.WriteLine(filterContext.Result);
            Debug.WriteLine("This Event Fired: OnResultExecuting ");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine(filterContext.RouteData.Values);
            Debug.WriteLine(filterContext.HttpContext);
            Debug.WriteLine(filterContext.Controller);
            Debug.WriteLine(filterContext.Result);
            Debug.WriteLine("This Event Fired: OnResultExecuted ");
        }
    }
}