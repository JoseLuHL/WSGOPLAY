using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAppsHash
    {
        public int Id { get; set; }
        public string HashId { get; set; }
        public int UserId { get; set; }
        public int Active { get; set; }
    }
}
