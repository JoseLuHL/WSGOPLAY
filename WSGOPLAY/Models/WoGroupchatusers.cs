using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoGroupchatusers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public string Active { get; set; }
        public string LastSeen { get; set; }
    }
}
