using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSportProgect.Models
{
    public class League
    {
        public int LeagueId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Club> Clubs { get; set; }
    }
}