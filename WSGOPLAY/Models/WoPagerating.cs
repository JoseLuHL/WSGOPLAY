using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPagerating
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public int? Valuation { get; set; }
        public string Review { get; set; }
    }
}
