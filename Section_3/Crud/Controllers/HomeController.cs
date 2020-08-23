using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crud.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
      
        private ForumContext db;
            public HomeController(ForumContext context)
            {
                db = context;
            }

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

        [HttpPost("/register")]
        public IActionResult Register(User newUser)
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
                return View("Index");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("UserName", newUser.FirstName);
            return RedirectToAction("All","Post");
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginUser loginUser)
        {
            // string genericErrMsg="Invald credientials";
            if(ModelState.IsValid == false)
            {
                return View("Index");
            }
            User dbUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);
            if (dbUser ==null)
            {
                ModelState.AddModelError("LoginEmail", "Email not found");
                return View("Index");
            }
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
            if (pwCompareResult ==0)
            {
                ModelState.AddModelError("LoginEmail", "wrong password");
                return View("Index");
            }
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("UserName", dbUser.FirstName);
            return RedirectToAction("All","Posts");
        }

        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        [HttpGet("/users/{userId}")]
        public IActionResult AuthorPage (int userId)
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index","Home");
            }
            User user = db.Users
            .Include(user => user.Posts)
            .FirstOrDefault( user => user.UserId == userId);
            if(user ==null)
            {
                return RedirectToAction("All","Posts");
            }
            return View("AuthorPage", user);
        }
        
        [HttpGet("")]
  
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
