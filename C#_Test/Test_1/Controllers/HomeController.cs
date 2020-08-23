using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


namespace Test_1.Controllers
{
    public class HomeController : Controller
    {
        private Test_1Context db;

        //Creating function to grab sessions
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        //To check if the person is logged in
        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        public HomeController(Test_1Context context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if (isLoggedIn)
            {
                return RedirectToAction("All", "Test");
            }

            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(User User)
        {
            
            if (ModelState.IsValid)
            {
                // if Any already user exists that matches the email
                if (db.Users.Any(u => u.Email == User.Email))
                {
                    ModelState.AddModelError("Email", "is taken");
                }
            }

            if (ModelState.IsValid == false)
            {
                // To display the custom error message above IF it was added, OR to display the other validation errors
                return View("Index");
            }

            // hash pw
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            User.Password = hasher.HashPassword(User, User.Password);

            db.Users.Add(User);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", User.UserId);
            HttpContext.Session.SetString("UserName", User.FirstName);
            return RedirectToAction("All", "Test");
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginUser loginUser)
        {
          

            if (ModelState.IsValid == false)
            {
                // display validation errors
                return View("Index");
            }
            
            User dbUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);

            if (dbUser == null)
            {
                //Adds an error when the email is not found
                ModelState.AddModelError("LoginEmail", "Email not found");
                return View("Index");
            }

            // Hasing passwords
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);

            if (pwCompareResult == 0)
            {
                // ModelState.AddModelError("LoginEmail", genericErrMsg);
                ModelState.AddModelError("LoginEmail", "wrong password");
                return View("Index");
            }

            // no returns happened, everything is good
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("UserName", dbUser.FirstName);
            return RedirectToAction("All", "Test");
        }

        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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