using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoUserGifts
    {
        public int Id { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public int GiftId { get; set; }
        public int? Time { get; set; }
    }
}
