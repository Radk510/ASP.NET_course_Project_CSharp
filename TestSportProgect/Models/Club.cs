using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSportProgect.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stadium { get; set; }
        public int? LeagueId { get; set; }
        public League League { get; set; }

    }
}