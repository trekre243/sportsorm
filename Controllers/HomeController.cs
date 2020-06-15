using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.EntityFrameworkCore;

namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context context;

        public HomeController(Context DBContext)
        {
            context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = context.Leagues
                .Where(l => l.Sport.Contains("Baseball"));
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.AllWomenLeagues = context.Leagues.Where(l => l.Name.Contains("Women"));
            ViewBag.HockeyLeagues = context.Leagues.Where(l => l.Sport.Contains("Hockey"));
            ViewBag.NotFootball = context.Leagues.Where(l => l.Sport != "Football");
            ViewBag.Conferences = context.Leagues.Where(l => l.Name.Contains("Conference"));
            ViewBag.Atlantic = context.Leagues.Where(l => l.Name.Contains("Atlantic"));
            ViewBag.Dallas = context.Teams.Where(t => t.Location.Contains("Dallas"));
            ViewBag.Raptors = context.Teams.Where(t => t.TeamName.Contains("Raptors"));
            ViewBag.City = context.Teams.Where(t => t.Location.Contains("City"));
            ViewBag.T = context.Teams.Where(t => t.TeamName[0] == 'T');
            ViewBag.AbyL = context.Teams.OrderBy(t => t.Location);
            ViewBag.NameRev = context.Teams.OrderByDescending(t => t.TeamName);
            ViewBag.Cooper = context.Players.Where(p => p.LastName == "Cooper");
            ViewBag.Joshua = context.Players.Where(p => p.FirstName == "Joshua");
            ViewBag.CooperNotJoshua = context.Players.Where(p => p.LastName == "Cooper" && p.FirstName != "Joshua");
            ViewBag.AlexanderWyatt = context.Players.Where(p => p.FirstName == "Alexander" || p.FirstName == "Wyatt");

            return View();
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