using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSportProgect.Models;

namespace TestSportProgect.Controllers
{
    public class HomeController : Controller
    {
        ClubContext database = new ClubContext();
        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult FootballClubs()
        {
            return View();
        }
        public ActionResult EnglandClubsList()
        {
            var clubs = database.Clubs.Where(i => i.League.Name == "FA Premier League").ToList();
            return PartialView(clubs);
        }

        public ActionResult SpainClubsList()
        {
            var clubs = database.Clubs.Where(i => i.League.Name == "LA Liga").ToList();
            return PartialView(clubs);
        }

        public ActionResult ItalyClubsList()
        {
            var clubs = database.Clubs.Where(i => i.League.Name == "Seria A").ToList();
            return PartialView(clubs);
        }

        public ActionResult ClubsInfo()
        {

            
            return View();
        }


        public string GetString(int some)
        {
            return some.ToString();
        }


    }
}