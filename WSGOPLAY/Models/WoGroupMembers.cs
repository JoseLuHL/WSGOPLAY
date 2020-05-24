using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoGroupMembers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int Time { get; set; }
        public string Active { get; set; }
    }
}
