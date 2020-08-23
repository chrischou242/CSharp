using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Time_Display 
{
  public class HomeController : Controller 
  {
      [HttpGet("")]
        public ViewResult index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.date = CurrentTime.ToString("MMM d, yyyy");
            ViewBag.time = CurrentTime.ToString("hh:mm tt");
            return View("index");
        }
  }
}