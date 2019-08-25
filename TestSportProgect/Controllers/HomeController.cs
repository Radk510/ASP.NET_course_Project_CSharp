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
        public ActionResult Index()
        {           
            return View();
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