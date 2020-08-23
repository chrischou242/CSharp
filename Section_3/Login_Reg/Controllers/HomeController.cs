using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Login_Reg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Login_Reg.Controllers
{
    public class HomeController : Controller
    {
          private LoginContext db;
            public HomeController(LoginContext context)
            {
                db = context;
            }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("user/login")]
        public IActionResult UserLogin(LoginUser loginUser)
        {
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
            return View("Success");
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost("registering")]
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
                return View("Index");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("UserName", newUser.FirstName);
            return View("Success", newUser);
        }
        
        [HttpGet("LogOut")]
         public IActionResult LogOut()
         {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
         }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
