using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Models
{
    public class LeagueViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nation { get; set; }
        public int Nation_id { get; set; }
    }
}  

