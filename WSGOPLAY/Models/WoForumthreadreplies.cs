using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoForumthreadreplies
    {
        public int Id { get; set; }
        public int ThreadId { get; set; }
        public int ForumId { get; set; }
        public int PosterId { get; set; }
        public string PostSubject { get; set; }
        public string PostText { get; set; }
        public int PostQuoted { get; set; }
        public int PostedTime { get; set; }
    }
}
