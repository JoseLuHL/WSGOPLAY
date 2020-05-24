using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoTokens
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AppId { get; set; }
        public string Token { get; set; }
        public int Time { get; set; }
    }
}
