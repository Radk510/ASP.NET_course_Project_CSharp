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
            context.SaveChanges();            

            List<Club> ClubsList = new List<Club>
             {
                new Club { Name = "Chelsea", Stadium = "Stamford Bridge", LeagueId = leagueOne.Id, infoPath = "ChelseaClub"},
                new Club { Name = "Liverpool", Stadium = "Enfield", LeagueId = leagueOne.Id, infoPath = "LiverpolClub"},
                new Club { Name = "Manchester United", Stadium = "Old Trafford", LeagueId = leagueOne.Id, infoPath = "ManUtdClub"},
                new Club { Name = "Manchester City", Stadium = "Etihard", LeagueId = leagueOne.Id, infoPath = "ManCtyClub"},
                new Club { Name = "Arsenal", Stadium = "Emirates", LeagueId = leagueOne.Id, infoPath = "ArsenalClub"},
                new Club { Name = "Tottenham Hotspur", Stadium = "Tottenham Hotspur Stadium", LeagueId = leagueOne.Id, infoPath = "TottenhamClub"},
                new Club { Name = "Barselona", Stadium = "Camp Nou", LeagueId = leagueTwo.Id, infoPath = "BarsaClub"},
                new Club { Name = "Real Madrid", Stadium = "Santiago Bernabeu", LeagueId = leagueTwo.Id, infoPath = "RealClub"},
                new Club { Name = "Atletico Madrid", Stadium = "Wanda Metropolitano", LeagueId = leagueTwo.Id, infoPath = "AtlMdrClub"},
                new Club { Name = "Sevilla", Stadium = "Estadio Ramón Sánchez Pizjuán", LeagueId = leagueTwo.Id, infoPath = "SevillaClub"},
                new Club { Name = "Juventus", Stadium = "Allianz Stadium", LeagueId = leagueThree.Id, infoPath = "JuveClub"},
                new Club { Name = "Milan", Stadium = "San Siro", LeagueId = leagueThree.Id, infoPath = "MilanClub"},
                new Club { Name = "Inter Milan", Stadium = "San Siro (Stadio Giuseppe Meazza)", LeagueId = leagueThree.Id, infoPath = "InterClub"},
                new Club { Name = "Napoli", Stadium = "Stadio San Paolo", LeagueId = leagueThree.Id, infoPath = "NapoliClub"},
                new Club { Name = "Roma", Stadium = "Stadio Olimpico", LeagueId = leagueThree.Id, infoPath = "RomaClub"}
            };

            context.Clubs.AddRange(ClubsList);
            context.SaveChanges();
           

            base.Seed(context);
        }

        
    }
}