using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoRecentsearches
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SearchId { get; set; }
        public string SearchType { get; set; }
    }
}
