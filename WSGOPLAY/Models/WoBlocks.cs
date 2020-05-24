using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoBlocks
    {
        public int Id { get; set; }
        public int Blocker { get; set; }
        public int Blocked { get; set; }
    }
}
