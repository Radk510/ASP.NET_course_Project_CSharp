using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSportProgect.Models;

namespace TestSportProgect.Controllers
{
    public class ClubsController : Controller
    {
        ClubContext dataBase = new ClubContext();               

        public ActionResult ChelseaClub()
        {
            return View();
        }

        public ActionResult LiverpolClub()
        {
            return View();
        }

        public ActionResult ManUtdClub()
        {
            return View();
        }

        public ActionResult ManCtyClub()
        {
            return View();
        }

        public ActionResult ArsenalClub()
        {
            return View();
        }

        public ActionResult TottenhamClub()
        {
            return View();
        }

        public ActionResult BarsaClub()
        {
            return View();
        }

        public ActionResult RealClub()
        {
            return View();
        }

        public ActionResult AtlMdrClub()
        {
            return View();
        }

        public ActionResult SevillaClub()
        {
            return View();
        }

        public ActionResult JuveClub()
        {
            return View();
        }

        public ActionResult MilanClub()
        {
            return View();
        }

        public ActionResult InterClub()
        {
            return View();
        }

        public ActionResult NapoliClub()
        {
            return View();
        }

        public ActionResult RomaClub()
        {
            return View();
        }
    }
}