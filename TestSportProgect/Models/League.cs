using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSportProgect.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Club> Clubs { get; set; }
    }
}