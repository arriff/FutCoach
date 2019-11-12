using System;
using System.Collections.Generic;

namespace FutData
{
    public partial class Cards
    {
        public int CardId { get; set; }
        public string CardVersion { get; set; }
        public int PlayerId { get; set; }

        public virtual Players Player { get; set; }
    }
}