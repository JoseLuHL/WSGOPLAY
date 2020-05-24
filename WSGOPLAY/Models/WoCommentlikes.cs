using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoCommentlikes
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
    }
}
