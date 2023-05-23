using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        public Coach Coach { get; set; }
        public List<Football_Player> Players { get; set; }
        public double AveragePlayersAge
        {
            get
            {
                int totalAge = 0;

                if (Players.Count > 0)
                {
                    foreach (var player in Players)
                    {
                        totalAge += player.Age;
                    }

                    return totalAge / Players.Count;
                }

                return 0;
            }
        }
    }
}
