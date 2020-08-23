using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Dojo_Dachi
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index()
        {
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            string action1 = HttpContext.Session.GetString("action1");
            string action2 = HttpContext.Session.GetString("action2");
            string action3 = HttpContext.Session.GetString("action3");
            string action4 = HttpContext.Session.GetString("action4");


            if (happiness==null)
            {
                HttpContext.Session.SetInt32("happiness",20);
                HttpContext.Session.SetInt32("fullness",20);
                HttpContext.Session.SetInt32("energy",50);
                HttpContext.Session.SetInt32("meals",3);
                happiness =20;
                fullness = 20;
                energy = 50;
                meals =3;
            }
            
            ViewBag.H= happiness;
            ViewBag.F= fullness;
            ViewBag.E=energy;
            ViewBag.M= meals;
            ViewBag.A1 = action1;
            ViewBag.A2 = action2;
            ViewBag.A3 = action3;


            return View ("Index");
        }
        [HttpPost("feed")]

        public IActionResult Feed()
        {
           
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? meals = HttpContext.Session.GetInt32("meals");

           

            meals -= 1;
            Random number = new Random();
            int randomNum = number.Next(1,101);
            
            if (meals ==0 )
            {
                return View ("Index");
            }
            else
            {
                if(randomNum>=75)
                {
                Random rand = new Random();
                fullness +=rand.Next(5,11);
                }
                else
                {
                    return RedirectToAction("Index");
                }
               
            }
            HttpContext.Session.SetInt32("fullness",(int)fullness);
            HttpContext.Session.SetInt32("meals",(int)meals);
            HttpContext.Session.SetString("action1","meals:" + (int)meals);
            HttpContext.Session.SetString("action2","full: " + (int)fullness );
            return RedirectToAction ("Index");
        }
        [HttpPost("play")]
        public IActionResult Play()
        {

            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
           
            energy -=5;
            Random rand = new Random();
            happiness +=rand.Next(5,11);
            
            HttpContext.Session.SetInt32("happiness",(int)happiness);
            HttpContext.Session.SetInt32("energy",(int)energy);
            HttpContext.Session.SetString("action1","energy:" + (int)energy);
            HttpContext.Session.SetString("action2","happiness: " + (int)happiness );
         

            
            return RedirectToAction ("Index");
        }

        [HttpPost("work")]
        public IActionResult Work()
        {
            int? energy = HttpContext.Session.GetInt32("energy");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? meals = HttpContext.Session.GetInt32("meals");


            energy -= 5;
            Random rand = new Random();
            meals +=rand.Next(1,4);

            HttpContext.Session.SetInt32("energy",(int)energy);
            HttpContext.Session.SetInt32("meals",(int)meals);
            HttpContext.Session.SetString("action1","energy:" + (int)energy);
            HttpContext.Session.SetString("action2","meals: " + (int)meals );
         


            return RedirectToAction ("Index");
        }

         [HttpPost("sleep")]
         public IActionResult Sleep()
         {
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? energy = HttpContext.Session.GetInt32("energy");
            

            energy += 15;
            fullness -= 5;
            happiness -=5;

            HttpContext.Session.SetInt32("happiness",(int)happiness);
            HttpContext.Session.SetInt32("fullness",(int)fullness);
            HttpContext.Session.SetInt32("energy",(int)energy);
            HttpContext.Session.SetString("action1","energy:" + (int)energy);
            HttpContext.Session.SetString("action2","happiness:" + (int)happiness );
            HttpContext.Session.SetString("action3", "fullness:"+ (int)fullness);
         
            
            return RedirectToAction ("Index");
         }

         [HttpPost ("restart")]
         public IActionResult Restart()
         {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
         }

    }
}