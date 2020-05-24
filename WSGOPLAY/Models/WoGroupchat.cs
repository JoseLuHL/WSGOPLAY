using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoGroupchat
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string GroupName { get; set; }
        public string Avatar { get; set; }
        public string Time { get; set; }
    }
}
