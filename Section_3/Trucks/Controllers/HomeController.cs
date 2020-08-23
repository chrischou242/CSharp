using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trucks.Models;

namespace Trucks.Controllers
{
    public class HomeController : Controller
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
        public HomeController(TrucksContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Register()
        {
            
            return View("Register");
        }
      

        [HttpPost("Registering")]
        public IActionResult Registering(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(db.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "is Taken");

                }
            }
            if(ModelState.IsValid ==false)
            {
                return View("Register");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("UserName", newUser.FirstName);
           
            return RedirectToAction("Trucks","Trucks");
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("Loginin")]

        public IActionResult Loginin(LoginUser loginUser)
        {
            if(ModelState.IsValid == false)
            {
                return View("Login");
            }
            User dbUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);
            if (dbUser ==null)
            {
                ModelState.AddModelError("LoginEmail", "Email not found");
                return View("Login");
            }
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
            if (pwCompareResult ==0)
            {
                ModelState.AddModelError("LoginEmail", "wrong password");
                return View("Login");
            }
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("UserName", dbUser.FirstName);
           
            return RedirectToAction("Trucks", "Trucks");
        }

        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
