using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoForumThreads
    {
        public int Id { get; set; }
        public int User { get; set; }
        public int Views { get; set; }
        public string Headline { get; set; }
        public string Post { get; set; }
        public string Posted { get; set; }
        public int LastPost { get; set; }
        public int Forum { get; set; }
    }
}
