using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoReactions
    {
        public int Id { get; set; }
        public uint UserId { get; set; }
        public uint? PostId { get; set; }
        public uint? CommentId { get; set; }
        public uint? ReplayId { get; set; }
        public string Reaction { get; set; }
    }
}
