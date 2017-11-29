using CurrencyWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurrencyWebApplication.Controllers
{
    public class TestController : Controller
    {
        IHello hello;

        public TestController(IHello hello)
        {
            this.hello = hello;
        }
        // GET: Test
        public ActionResult Index()
        {
            return View(hello);
        }
    }
}