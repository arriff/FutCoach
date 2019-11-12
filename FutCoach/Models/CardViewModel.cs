using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Models
{
    public class CardViewModel
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public int Player_id { get; set; }
    }
}  

