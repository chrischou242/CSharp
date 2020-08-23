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
    public class DishController : Controller
    {
        private Chefs_N_DishesContext db;
            public DishController(Chefs_N_DishesContext context)
            {
                db = context;
            }

            [HttpGet("ViewDish")]
            public IActionResult ViewDish()
            {
                List<Dish> allDishes=db.Dishes
                .Include(Dish => Dish.Creater)/// chef that creates the dish
                .ThenInclude(Chef => Chef.CreatedDishes)//list of all dishes that chefs created
                .ToList();
                return View("Dish", allDishes);
            }
            
            [HttpGet("ViewNewDish")]
            public IActionResult NewDish()
            {
                NewDishWrapper DishWrapper = new NewDishWrapper();
                DishWrapper.AllChefs = db.Chefs
                .Include(F => F.CreatedDishes)
                
                .ToList(); 
                return View("NewDish", DishWrapper);
            }


            [HttpPost("CreateDish")]
            public IActionResult AddDish(NewDishWrapper NewDishWrapper)
            {
                if(ModelState.IsValid ==false)
                {
                NewDishWrapper DishWrapper = new NewDishWrapper();
                DishWrapper.AllChefs = db.Chefs
                
                .ToList(); 
                    return View("NewDish",DishWrapper);
                }
                db.Dishes.Add(NewDishWrapper.Form);
                db.SaveChanges();
                return RedirectToAction("ViewDish");
            }

            [HttpGet("DishHome")]
            public IActionResult DishHome()
            {
                return RedirectToAction("ViewDish");
            }

    }
}


