using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPinnedposts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public int GroupId { get; set; }
        public int PostId { get; set; }
        public int EventId { get; set; }
        public string Active { get; set; }
    }
}
