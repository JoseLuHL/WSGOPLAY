using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoUserstorymedia
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string Type { get; set; }
        public string Filename { get; set; }
        public string Expire { get; set; }
    }
}
