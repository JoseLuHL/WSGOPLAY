using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoHashtags
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Tag { get; set; }
        public int LastTrendTime { get; set; }
        public int TrendUseNum { get; set; }
        public DateTime? Expire { get; set; }
    }
}
