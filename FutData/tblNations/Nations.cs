using System;
using System.Collections.Generic;

namespace FutData
{
    public partial class Nations
    {
        public Nations()
        {
            Leagues = new HashSet<Leagues>();
        }

        public int NationId { get; set; }
        public string NationName { get; set; }

        public virtual ICollection<Leagues> Leagues { get; set; }
    }
}