using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoNotifications
    {
        public int Id { get; set; }
        public int NotifierId { get; set; }
        public int RecipientId { get; set; }
        public int PostId { get; set; }
        public uint? ReplyId { get; set; }
        public uint? CommentId { get; set; }
        public int PageId { get; set; }
        public int GroupId { get; set; }
        public int EventId { get; set; }
        public int ThreadId { get; set; }
        public int BlogId { get; set; }
        public int StoryId { get; set; }
        public int SeenPop { get; set; }
        public string Type { get; set; }
        public string Type2 { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string FullLink { get; set; }
        public int Seen { get; set; }
        public int SentPush { get; set; }
        public int Time { get; set; }
    }
}
