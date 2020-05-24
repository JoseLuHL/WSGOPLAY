using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAgoravideocall
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string Type { get; set; }
        public string RoomName { get; set; }
        public int Time { get; set; }
        public string Status { get; set; }
    }
}
