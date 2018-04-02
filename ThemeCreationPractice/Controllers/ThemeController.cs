using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemeCreationPractice.Controllers
{
    public class ThemeController : Controller
    {
        // GET: Theme
        public ActionResult Theme1()
        {
            return PartialView();
        }
    }
}