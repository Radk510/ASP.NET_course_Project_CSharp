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

        public string infoPath { get; set; }
        public int? LeagueId { get; set; }
        public League League { get; set; }

        public string GetStadiumPhotoPath
        {
            get
            {
                return Name.Replace(" ", "-").ToLower() + "-stadium" + ".jpg";
            }
        }

        public string GetClubLogoPath
        {
            get
            {
                return Name.Replace(" ", "-").ToLower() + "-logo" + ".png";
            }
        }

        public Club GetClubInfo(int id)
        {
            Club clubReturn = null;
            ClubContext database = new ClubContext();
            foreach (var club in database.Clubs)
            {
                if (club.Id == id)
                {
                    clubReturn = club;
                    break;
                }
            }
            return clubReturn;
        }

    }
}