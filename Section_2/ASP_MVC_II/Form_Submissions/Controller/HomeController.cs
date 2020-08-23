using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Form_Submissions.Models;

namespace Form_Submissions
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("submit")]
        public IActionResult Login(Login user)
        {
           if(ModelState.IsValid)
           {
               return View("Login",user);
           }
           else
           {
               return Index();
           }
        }
    }
}


