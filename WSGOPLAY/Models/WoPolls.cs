using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPolls
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public int Time { get; set; }
    }
}
