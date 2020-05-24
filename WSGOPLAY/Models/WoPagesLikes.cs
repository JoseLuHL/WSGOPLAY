using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPagesLikes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public int Time { get; set; }
        public string Active { get; set; }
    }
}
