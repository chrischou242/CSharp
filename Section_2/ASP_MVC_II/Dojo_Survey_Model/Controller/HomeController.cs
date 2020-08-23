using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_Model.Models;

namespace Dojo_Survey_Model
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }


        [HttpPost("survey")]
        public IActionResult SurveyAnswers(Survey answers)
        {
            
            return View("SurveyAnswers", answers);
        }
    }


}