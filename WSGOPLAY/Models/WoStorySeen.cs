using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoStorySeen
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StoryId { get; set; }
        public string Time { get; set; }
    }
}
