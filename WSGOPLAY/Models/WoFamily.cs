using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoFamily
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int Member { get; set; }
        public string Active { get; set; }
        public int UserId { get; set; }
        public int Requesting { get; set; }
    }
}
