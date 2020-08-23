using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Login.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
         private LoginContext db;
            public LoginController(LoginContext context)
            {
                db = context;
            }

        [HttpGet("MainLogin")]
        public IActionResult NewLogin()
        {
            return View("LoginIn");
        }

        [HttpPost("LoginIn")]
        public IActionResult Login(LoginUser loginUser)
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
            return RedirectToAction("Index","Home");
        }

       
        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index" ,"Home");
        }

    }
}