using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoUseradsData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AdId { get; set; }
        public int Clicks { get; set; }
        public int Views { get; set; }
        public float Spend { get; set; }
        public DateTime Dt { get; set; }
    }
}
