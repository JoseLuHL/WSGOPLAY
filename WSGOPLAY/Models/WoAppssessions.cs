using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAppssessions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionId { get; set; }
        public string Platform { get; set; }
        public string PlatformDetails { get; set; }
        public int Time { get; set; }
    }
}
