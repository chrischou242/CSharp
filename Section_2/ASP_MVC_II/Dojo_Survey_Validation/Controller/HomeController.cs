using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_Validation.Models;

namespace Dojo_Survey_Validation
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("submit")]
        public IActionResult Submit(Survey user)
        {
            if(ModelState.IsValid){
                return View("Submit", user);
            }
            else
            {
                return Index();
            }
            
        }
        
    }
}
