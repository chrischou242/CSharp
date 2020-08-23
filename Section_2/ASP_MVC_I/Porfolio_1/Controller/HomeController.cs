using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Porfolio_1
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public string index()
        {
            return "This is my Index!";
        }

        [HttpGet("projects")]
         public string projects()
        {
            return "These ae my projects ";
        }

        [HttpGet("contacts")]
         public string contacts()
        {
            return "This is my Contact! ";
        }

    }
}