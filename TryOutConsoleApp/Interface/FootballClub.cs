using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp
{
    public interface FootballClub {
        string GetStarPlayer();
    }
    public interface City
    {
        string getCityName();
    }

    public class Chelsea : FootballClub, City {
        private string starPlayer;
        private string city;

        public Chelsea(string player, string cityName) {
            starPlayer = player;
            city = cityName;
        }

        public string getCityName()
        {
            return city;
        }

        public string GetStarPlayer() {
            return starPlayer;
        }
    }
}