using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Models
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string League { get; set; }
        public string Nation { get; set; }
        public int League_id { get; set; }
    }
}  

