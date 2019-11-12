using System;
using System.Collections.Generic;

namespace FutData
{
    public partial class Leagues
    {
        public Leagues()
        {
            Teams = new HashSet<Teams>();
        }

        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string LeagueNation { get; set; }
        public int NationId { get; set; }

        public virtual Nations Nation { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
    }
}