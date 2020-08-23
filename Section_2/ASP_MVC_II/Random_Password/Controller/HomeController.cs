using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Random_Password
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {   
            int? number = HttpContext.Session.GetInt32("counter");
            ViewBag.count =number;
            
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[14];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);

            ViewBag.password = finalString;
            return View("Index");
        }

        [HttpPost("Password")]
        public IActionResult Password()
        {
          
            
            int? counter = HttpContext.Session.GetInt32("counter");

            if (counter ==null)
            {
                HttpContext.Session.SetInt32("counter",0);
            }
            else
            {
                counter++;
                HttpContext.Session.SetInt32("counter",(int)counter);
            }
              
            return Index();
        }
    }
}


            