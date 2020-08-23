using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Razor_Fun
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View("index");
        }
    }

}