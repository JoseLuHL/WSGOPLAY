using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoActivities
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public uint? ReplyId { get; set; }
        public uint? CommentId { get; set; }
        public int FollowId { get; set; }
        public string ActivityType { get; set; }
        public int Time { get; set; }
    }
}
