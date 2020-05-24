using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoForums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sections { get; set; }
        public int Posts { get; set; }
        public int LastPost { get; set; }
    }
}
