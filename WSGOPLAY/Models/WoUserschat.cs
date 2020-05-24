using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoUserschat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ConversationUserId { get; set; }
        public int Time { get; set; }
        public string Color { get; set; }
    }
}
