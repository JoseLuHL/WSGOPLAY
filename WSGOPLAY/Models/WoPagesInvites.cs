using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPagesInvites
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int InviterId { get; set; }
        public int InvitedId { get; set; }
    }
}
