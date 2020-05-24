using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoComments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public string Record { get; set; }
        public string CFile { get; set; }
        public int Time { get; set; }
    }
}
