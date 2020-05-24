using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoUserads
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Audience { get; set; }
        public string AdMedia { get; set; }
        public string Gender { get; set; }
        public string Bidding { get; set; }
        public int Clicks { get; set; }
        public int Views { get; set; }
        public string Posted { get; set; }
        public int Status { get; set; }
        public string Appears { get; set; }
        public int UserId { get; set; }
    }
}
