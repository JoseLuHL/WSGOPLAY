using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoEvents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndTime { get; set; }
        public int PosterId { get; set; }
        public string Cover { get; set; }
    }
}
