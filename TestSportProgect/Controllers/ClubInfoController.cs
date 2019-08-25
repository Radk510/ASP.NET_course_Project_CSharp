using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSportProgect.Models;

namespace TestSportProgect.Controllers
{
    public class ClubInfoController : Controller
    {

        ClubContext database = new ClubContext();

        private Club _club = null;

        public ClubInfoController()
        {
            _club = new Club();
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

        public ActionResult ClubDetail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Club club = _club.GetClubInfo((int)id);
            return View(club);
        }
    }
}