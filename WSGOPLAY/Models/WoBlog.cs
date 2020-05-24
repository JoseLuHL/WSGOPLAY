using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoBlog
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Posted { get; set; }
        public int? Category { get; set; }
        public string Thumbnail { get; set; }
        public int? View { get; set; }
        public int? Shared { get; set; }
        public string Tags { get; set; }
    }
}
