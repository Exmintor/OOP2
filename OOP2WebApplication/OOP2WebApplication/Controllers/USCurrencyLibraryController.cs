using CurrencyLibrary.USCurrency;
using CurrencyLibrary;
using CurrencyLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OOP2WebApplication.Controllers
{
    public class USCurrencyLibraryController : Controller
    {
        private USCurrencyRepo usCurrencyRepo;
        public USCurrencyRepo UsCurrencyRepo
        {
            get
            {
                if (usCurrencyRepo == null)
                {
                    usCurrencyRepo = new USCurrencyRepo();
                }
                return usCurrencyRepo;
            }
            set
            {
                usCurrencyRepo = value;
            }
        }
        // GET: USCurrencyLibrary
        public ActionResult Index(double? amount)
        {
            if(amount == null)
            {
                return View(UsCurrencyRepo);
            }
            UsCurrencyRepo = (USCurrencyRepo)UsCurrencyRepo.MakeChange((double)amount);
            return View(UsCurrencyRepo);
        }
    }
}