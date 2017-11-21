using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OOP2WebApplication.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(string Name)
        {
            ViewBag.Name = Name;
            return View();
        }
    }
}