using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAffiliatesRequests
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Amount { get; set; }
        public string FullAmount { get; set; }
        public int Status { get; set; }
        public int Time { get; set; }
    }
}
