using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCIOCAutoFac.Repositories;

namespace MVCIOCAutoFac.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public IUserProvider UserProvider { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var userName = UserProvider.UserName;
        }

    }
}