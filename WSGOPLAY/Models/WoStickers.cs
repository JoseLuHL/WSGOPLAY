using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoStickers
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string MediaFile { get; set; }
        public int Time { get; set; }
    }
}
