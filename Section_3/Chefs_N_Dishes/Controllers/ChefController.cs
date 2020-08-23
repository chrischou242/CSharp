using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chefs_N_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs_N_Dishes.Controllers
{
    public class ChefController : Controller
    {
         private Chefs_N_DishesContext db;
            public ChefController(Chefs_N_DishesContext context)
            {
                db = context;
            }

            [HttpGet("ViewChef")]
            public IActionResult ViewChef()
            {
                List<Chef> allChefs=db.Chefs
                .Include(Chef => Chef.CreatedDishes)
                .ToList();
                return View("Chef", allChefs);
            }


            [HttpGet("New/Chef")]
            public IActionResult NewChef()
            {
                return View("NewChef");
            }

            [HttpPost("New/Chef/Add")]
            public IActionResult AddChef(Chef NewChef)
            {
                if(!ModelState.IsValid )
                {
                    return View("NewChef");
                }
                db.Chefs.Add(NewChef);
                db.SaveChanges();
                return RedirectToAction("ViewChef");
            }

            [HttpGet("Home")]
            public IActionResult Home()
            {
                return RedirectToAction("ViewChef");
            }
    }
}