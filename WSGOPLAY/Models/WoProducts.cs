using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoProducts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public int Time { get; set; }
        public string Active { get; set; }
    }
}
