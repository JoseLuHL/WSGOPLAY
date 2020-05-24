using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoCommentRepliesWonders
    {
        public int Id { get; set; }
        public int ReplyId { get; set; }
        public int UserId { get; set; }
    }
}
