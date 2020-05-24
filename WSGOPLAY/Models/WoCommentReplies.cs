using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoCommentReplies
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public string Text { get; set; }
        public int Time { get; set; }
    }
}
