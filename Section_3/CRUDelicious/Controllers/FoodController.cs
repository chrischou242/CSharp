using System;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace CRUDelicious.Controllers
{
    public class FoodController : Controller
    {
        private CRUDeliciousContext db;
        public FoodController(CRUDeliciousContext context)
        {
            db = context;
        }

        [HttpGet("/posts")]
            public IActionResult All()
            {
                List<Food> allfoods=db.Foods.ToList();
                return View("All", allfoods);
            } 

        [HttpGet("/posts/newfood")]
        public IActionResult NewFood()
        {
            return View("NewFood");
        }

        [HttpPost("/posts/create")]
        public IActionResult AddANewFood(Food newFood)
        {
            if(ModelState.IsValid ==false)
                {
                    return View("NewFood");
                }
                db.Foods.Add(newFood);
                db.SaveChanges();
                return RedirectToAction("All", newFood);
        }


        [HttpGet("/info/{DishIds}")]
        public IActionResult Info(int DishIds)
        {
            Food SpecificFood = db.Foods.SingleOrDefault(Foods => Foods.DishId ==DishIds);
            return View("FoodInfo", SpecificFood);
        }

        [HttpGet("/delete/{DishId}")]
        public IActionResult Delete(int DishId)
        {
            Food DeleteFood = db.Foods.SingleOrDefault(Foods => Foods.DishId == DishId);
            db.Foods.Remove(DeleteFood);
            db.SaveChanges();
            return RedirectToAction("All");
        }

        [HttpGet("/edit/{DishIds}")]
        public IActionResult Edit(int DishIds)
        {
            Food EditFood = db.Foods.SingleOrDefault(Foods =>Foods.DishId == DishIds);
            return View ("EditInfo",EditFood);
        }

        [HttpPost("/edit/{DishIds}/Food")]
        public IActionResult EditFoods(Food Dishing ,int DishIds )
        {
            Food EditFood = db.Foods.FirstOrDefault(Foodss=>Foodss.DishId == DishIds);
            EditFood.NameOfDish= Dishing.NameOfDish;
            EditFood.ChefName=Dishing.ChefName;
            EditFood.Calories=Dishing.Calories;
            EditFood.Tastiness=Dishing.Tastiness;
            EditFood.Description=Dishing.Description;
            db.SaveChanges();
            
            return RedirectToAction ("All",Dishing);
        }
         
    }
}

  