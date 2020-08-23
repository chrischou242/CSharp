using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            
            ViewBag.Womenleagues=_context.Leagues.Where(M =>M.Name.Contains("Women")).ToList();

            ViewBag.HockeyLeagues = _context.Leagues.Where(hockey =>hockey.Sport.Contains("Hockey")).ToList();

            // ViewBag.OtherThanFootBall = _context.Leagues.Except(foot =>foot.Name.Contains("Football")).ToList();
            
            ViewBag.Conferences = _context.Leagues.Where(C=>C.Name.Contains("Conference"));
            
            
            ViewBag.Atlantics= _context.Leagues.Where(Atlantic=>Atlantic.Name.Contains("Atlantic"));
            
            ViewBag.Dallas = _context.Teams.Where(Dallass=>Dallass.Location.Contains("Dallas"));
            
            ViewBag.Raptors = _context.Teams.Where(Raptors=>Raptors.TeamName.Contains("Raptors"));
            
            ViewBag.City = _context.Teams.Where(Cities=>Cities.Location.Contains("City"));

            ViewBag.Teamss= _context.Teams.Where(T=>T.TeamName.Contains("T"));

            ViewBag.Ordered = _context.Teams.OrderBy(O => O.Location);

            // ViewBag.inRevOrder =_context.Teams.Reverse(R=>R.TeamName);

            ViewBag.Cooper = _context.Players.Where(C => C.LastName.Contains("Cooper"));

            ViewBag.Joshua = _context.Players.Where(J => J.FirstName.Contains("Joshua"));

            ViewBag.allFirstNames = _context.Players.All(f => f.FirstName.Contains("Alexander && Wyatt"));




            return View("Level1");
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}



// ...every player with last name "Cooper"
// ...every player with first name "Joshua"
// ...every player with last name "Cooper" EXCEPT those with "Joshua" as the first name
// ...all players with first name "Alexander" OR first name "Wyatt"