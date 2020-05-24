using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoUserstory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Posted { get; set; }
        public string Expire { get; set; }
        public string Thumbnail { get; set; }
    }
}
