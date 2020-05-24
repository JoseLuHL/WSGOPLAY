using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoWonders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int Type { get; set; }
    }
}
