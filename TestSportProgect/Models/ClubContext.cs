using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestSportProgect.Models
{
    public class ClubContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<League> Leagues { get; set; }

    }
}