﻿using Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            QuoteLogic quote = new QuoteLogic();

            string[] quoteAndAuthor = quote.GetQuote();

            ViewBag.Quote = quoteAndAuthor[0];
            
            ViewBag.Author = quoteAndAuthor[1];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}