using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoEinvited
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int InviterId { get; set; }
        public int InvitedId { get; set; }
    }
}
