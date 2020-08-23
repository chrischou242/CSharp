using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey
{
    public class HomeController :Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Index(string name, string location, string language, string comment )
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View ("Dojo");
        }

       

    }
}