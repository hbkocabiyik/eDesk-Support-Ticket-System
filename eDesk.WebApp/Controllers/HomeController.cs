using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eDesk.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}