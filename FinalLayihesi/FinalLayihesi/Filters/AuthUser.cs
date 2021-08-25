using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Filters
{
    public class AuthUser : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.GetString("ValidUser") == null)
            {
                filterContext.Result = new RedirectResult("~/admin");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
