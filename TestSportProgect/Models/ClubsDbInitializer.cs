using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestSportProgect.Models
{
    public class ClubsDbInitializer : DropCreateDatabaseAlways<ClubContext>
    {
        protected override void Seed(ClubContext context)
        {

            League leagueOne = new League { Name = "FA Premier League", Country = "England" };
            League leagueTwo = new League { Name = "LA Liga", Country = "Spain" };
            League leagueThree = new League { Name = "Seria A", Country = "Italy" };
            context.Leagues.Add(leagueOne);
            context.Leagues.Add(leagueTwo);
            context.Leagues.Add(leagueThree);

           


            List<Club> ClubsList = new List<Club>
             {
                new Club { Name = "Chelsea", Stadium = "Stamford Bridge"},
                new Club { Name = "Liverpool", Stadium = "Enfield"},
                new Club { Name = "Manchester United", Stadium = "Old Trafford"},
                new Club { Name = "Manchester City", Stadium = "Etihard"},
                new Club { Name = "Arsenal", Stadium = "Emirates"},
                new Club { Name = "Tottenham Hotspur", Stadium = "Tottenham Hotspur Stadium"},
                new Club { Name = "Barselona", Stadium = "Camp Nou"},
                new Club { Name = "Real Madrid", Stadium = "Santiago Bernabeu"},
                new Club { Name = "Atletico Madrid", Stadium = "Wanda Metropolitano"},
                new Club { Name = "Sevilla", Stadium = "Estadio Ramón Sánchez Pizjuán"},
                new Club { Name = "Juventus", Stadium = "Allianz Stadium"},
                new Club { Name = "Milan", Stadium = "San Siro" },
                new Club { Name = "Inter Milan", Stadium = "San Siro (Stadio Giuseppe Meazza)"},
                new Club { Name = "Napoli", Stadium = "Stadio San Paolo" },
                new Club { Name = "Roma", Stadium = "Stadio Olimpico"}
            };

            context.Clubs.AddRange(ClubsList);
            
            base.Seed(context);
        }
    }
}