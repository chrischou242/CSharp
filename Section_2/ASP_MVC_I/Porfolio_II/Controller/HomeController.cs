using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Porfolio_1
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contacts")]
         public ViewResult Contacts()
        {
            return View();
        }

    }
}