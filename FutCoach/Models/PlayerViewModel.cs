using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nation { get; set; }
        public string Team { get; set; }
        public string League { get; set; }
        public string Position { get; set; }
        public int Pace { get; set; }
        public int Shooting { get; set; }
        public int Passing { get; set; }
        public int Dribbling { get; set; }
        public int Defending { get; set; }
        public int Physicality { get; set; }
        public int Team_id { get; set; }
    }
}  

