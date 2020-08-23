using Trucks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Trucks.Controllers
{
    public class TrucksController : Controller
    {
        private TrucksContext db;
       
         private int? uid
        {
            get{
                return HttpContext.Session.GetInt32("UserId");
            }
        }

            
        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        public TrucksController(TrucksContext context)
        {
            db = context;
        }

        [HttpGet("/trucks")]
        public IActionResult Trucks()
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Register","Home");
            }

            List<Truck> allTrucks =db.Trucks
            .Include(t => t.SubmittedBy)
            .Include(t => t.Reviews)
            .ThenInclude(review => review.Author)
            .ToList();
            return View("Trucks", allTrucks);
        }
          


        [HttpGet("trucks/new")]
        public IActionResult New()
        {
             if(!isLoggedIn)
            {
                return RedirectToAction("Register","Home");
            }
            return View("New");
        }

        [HttpPost("trucks/new/create")]
        public IActionResult Create(Truck newTruck )
        {
            if(ModelState.IsValid == false)
            {
                return View("New");
            }

            newTruck.UserId=(int)uid;
            db.Trucks.Add(newTruck);
            db.SaveChanges();
            return RedirectToAction("Trucks");
        }

        
        [HttpGet("/trucks/{truckId}/edit")]
        public IActionResult Edit(int truckId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Register", "Home");
            }

            Truck truck = db.Trucks
            .Include(t => t.SubmittedBy)

            .Include(t => t.Reviews)
            .ThenInclude(review => review.Author)
            .FirstOrDefault(t => t.TruckId == truckId);

            if (truck == null)
            {
                return RedirectToAction("Trucks");
            }

            return View("Edit", truck);
        }
         public DbSet<User> Users { get; set; }

        
        [HttpPost("Edit/{TruckId}")]
        public IActionResult Editing(Truck editTruck , int TruckId)
        {
            if (ModelState.IsValid == false)
            {
    
                return View("Edit", editTruck);
            }

            Truck dbTruck = db.Trucks.FirstOrDefault(t => t.TruckId == TruckId);

            if (dbTruck == null)
            {
                return RedirectToAction("Trucks");
            }

            dbTruck.Name = editTruck.Name;
            dbTruck.Style = editTruck.Style;
            dbTruck.Description = editTruck.Description;
            dbTruck.ImgUrl = editTruck.ImgUrl;
            dbTruck.UpdatedAt = DateTime.Now;

            db.Trucks.Update(dbTruck);
            db.SaveChanges();
            return RedirectToAction("Trucks");

        }

        [HttpGet("cancel")]
        public IActionResult cancel()
        {
             if (!isLoggedIn)
            {
                return RedirectToAction("Register", "Home");
            }

            return RedirectToAction ("Trucks");

        }

            [HttpGet("delete/{TruckId}")]
        public IActionResult delete(int TruckId)
            {
            if (!isLoggedIn)
            {
                return RedirectToAction("Register", "Home");
            }

            
            Truck truck = db.Trucks.FirstOrDefault(t => t.TruckId == TruckId);

            if (truck == null || truck.UserId != uid)
            {
                return RedirectToAction("All");
            }

            db.Trucks.Remove(truck);
            db.SaveChanges();
            return RedirectToAction("All");
        }
    }
}
