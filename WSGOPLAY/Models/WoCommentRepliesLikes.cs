using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoCommentRepliesLikes
    {
        public int Id { get; set; }
        public int ReplyId { get; set; }
        public int UserId { get; set; }
    }
}
