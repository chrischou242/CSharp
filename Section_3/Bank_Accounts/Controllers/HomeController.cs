using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bank_Accounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Bank_Accounts.Controllers
{
    public class HomeController : Controller
    {
        private Bank_AccountsContext db;
        public HomeController(Bank_AccountsContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost("register")]
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
           
            return RedirectToAction("ViewMoney","Money");
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
           
            return RedirectToAction("ViewMoney", "Money");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
