using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoReports
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public uint CommentId { get; set; }
        public int ProfileId { get; set; }
        public int PageId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public int Seen { get; set; }
        public int Time { get; set; }
    }
}
