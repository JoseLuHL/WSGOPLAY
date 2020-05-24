using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoBannedIp
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public int Time { get; set; }
    }
}
