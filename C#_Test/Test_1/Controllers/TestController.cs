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
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Test_1.Controllers
{
    public class TestController : Controller
    {
        private Test_1Context db;

        private int? uid
        {
            get
            {
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

        public TestController(Test_1Context context)
        {
            db = context;
        }

        [HttpGet("All")]
        public IActionResult All()
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index","Home");
            }

            ActivityWrapper ActWrapper = new ActivityWrapper();
            
            ActWrapper.AllActivities = db.Activities
                .Include(A => A.Activiting)
                .Include(A => A.PeopleJoining)
                .ThenInclude(Join => Join.activities)
                .OrderBy(A => A.Time)
                .ToList();
            
            ActWrapper.LoggedUser = db.Users.FirstOrDefault(U => U.UserId ==(int)uid);
            
          
        
            return View("All",ActWrapper);
        }

        [HttpGet("New")]
            public IActionResult New()
            {
                return View("New");
            }

        [HttpPost("CreateActivity")]
            public IActionResult AddAct(Activityy NewAct)
            {

                if(!isLoggedIn)
                {
                    return RedirectToAction("Index","Home");
                }


                if(ModelState.IsValid)
                {
                    if(NewAct.Time < DateTime.Today)
                    {
                        ModelState.AddModelError("Time", "cannot be in the past");
                        return View("New");
                    }
                    
                }
                
                
                NewAct.UserId=(int)uid;
                db.Activities.Add(NewAct);
                db.SaveChanges();
                return RedirectToAction("Details", new {ActId = NewAct.ActivityId});
            }

        [HttpGet("Details/{ActId}")]
            public IActionResult Details(int ActId)
            {
            
            
            if (isLoggedIn)
            {
                DetailWrapper Detail = new DetailWrapper();
                Detail.Activities = db.Activities
                .Include(A => A.Activiting)
                .Include(A => A.PeopleJoining)
                .ThenInclude( A =>A.Guest)
                .FirstOrDefault(A => A.ActivityId == ActId);

                Detail.LoggedUser = db.Users
                .FirstOrDefault(A => A.UserId == (int)uid);

                return View("Detail", Detail);
            }
            return RedirectToAction("Index", "Home");
        }


           [HttpGet("ActHome")]
            public IActionResult ActHome()
            {
                return RedirectToAction("All");
            }


            [HttpGet("delete/{ActId}")]
            public IActionResult delete(int ActId)
            {
            if (!isLoggedIn)
            {
                return RedirectToAction("Register", "Home");
            }

            
            Activityy Act = db.Activities.FirstOrDefault (A => A.ActivityId == ActId);

            if (Act == null || Act.UserId != uid)
            {
                return RedirectToAction("All");
            }

            db.Activities.Remove(Act);
            db.SaveChanges();
            return RedirectToAction("All");
            }



            [HttpGet("Leave/{ActId}")]
            public IActionResult Leave(int ActId)
            {
                if (!isLoggedIn)
                {
                return RedirectToAction("Register", "Home");
                }

                Activityy leaving= db.Activities
                .Include (A => A.PeopleJoining) 
                .FirstOrDefault(A => A.ActivityId ==ActId);

                if (leaving==null || !leaving.PeopleJoining.Any( A => A.UserId == (int)uid))
                {
                    return RedirectToAction("All");
                }
                else
                {
                Join toleave = db.Joins.FirstOrDefault( A =>A.UserId ==(int)uid);
                db.Remove(toleave);
                db.SaveChanges();
                return RedirectToAction("All");
                }
            }
            
            [HttpGet("join/{ActId}")]
            public IActionResult Join(int ActId)
            {
                if (!isLoggedIn)
                {
                return RedirectToAction("Register", "Home");
                }

                Activityy joining= db.Activities
                .Include (A => A.PeopleJoining) 
                .FirstOrDefault(A => A.ActivityId ==ActId);

                if (joining==null || joining.UserId == (int)uid)
                {
                    return RedirectToAction("All");
                }
                else
                {
                    Join newJoin = new Join()
                    {
                        UserId= (int)uid,
                        ActivitiesId=ActId
                    };
                    db.Add(newJoin);
                    db.SaveChanges();
                    return RedirectToAction("All");
                }

            }
    }
}



