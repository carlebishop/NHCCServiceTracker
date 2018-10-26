using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHCCServiceTracker.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name)  // mvc will try to figure out how to populate the parameter from the query string
        {
            var message = Server.HtmlEncode(name);  // prevents cross site scripting

            return Content(message);  // bypasses view

           
        }
    }
}