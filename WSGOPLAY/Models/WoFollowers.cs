using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoFollowers
    {
        public int Id { get; set; }
        public int FollowingId { get; set; }
        public int FollowerId { get; set; }
        public int IsTyping { get; set; }
        public int Active { get; set; }
    }
}
