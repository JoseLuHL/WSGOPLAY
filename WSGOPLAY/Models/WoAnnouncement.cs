using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAnnouncement
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Time { get; set; }
        public string Active { get; set; }
    }
}
