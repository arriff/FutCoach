using System;
using System.Collections.Generic;

namespace FutData
{
    public partial class Teams
    {
        public Teams()
        {
            Players = new HashSet<Players>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamLeague { get; set; }
        public string TeamNation { get; set; }
        public int LeagueId { get; set; }

        public virtual Leagues League { get; set; }
        public virtual ICollection<Players> Players { get; set; }
    }
}