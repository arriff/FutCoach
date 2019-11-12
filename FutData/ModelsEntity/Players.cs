using System;
using System.Collections.Generic;

namespace FutData
{
    public partial class Players
    {
        public Players()
        {
            Cards = new HashSet<Cards>();
        }

        public int PlayerId { get; set; }
        public string PlayerFirstname { get; set; }
        public string PlayerLastname { get; set; }
        public string PlayerNation { get; set; }
        public string PlayerTeam { get; set; }
        public string PlyaerLeague { get; set; }
        public string PlayerPosition { get; set; }
        public int PlayerPace { get; set; }
        public int PlayerShooting { get; set; }
        public int PlayerPassing { get; set; }
        public int PlayerDribbling { get; set; }
        public int PlayerDefending { get; set; }
        public int PlayerPhysicality { get; set; }
        public int TeamId { get; set; }

        public virtual Teams Team { get; set; }
        public virtual ICollection<Cards> Cards { get; set; }
    }
}