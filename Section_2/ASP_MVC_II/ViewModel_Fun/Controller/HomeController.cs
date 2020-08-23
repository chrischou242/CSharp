using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ViewModel_Fun
{
    public class HomeController: Controller
    {
       [HttpGet("")]
       public ViewResult Index()
       {
           return View("Index", "Hi, my name is Chris Chou");
       }

       [HttpGet("number")]
       public ViewResult Number()
       {
           int[] numbers = new int[]
           {
               1,2,3,4,5
           };
           return View("Number",numbers);
       }

        [HttpGet("users")]
       public ViewResult Users()
       {
           List<string> users = new List<string>
           {
               "chris","Red Belt","black belt", "green belt"
           };
           return View("Users",users);
       }

        [HttpGet("user/{person}")]
        public IActionResult Person(string person)
        {
            return View("person",person);
        }
      
    }
}