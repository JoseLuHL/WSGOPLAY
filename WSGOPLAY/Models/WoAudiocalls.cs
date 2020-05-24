using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAudiocalls
    {
        public int Id { get; set; }
        public string CallId { get; set; }
        public string AccessToken { get; set; }
        public string CallId2 { get; set; }
        public string AccessToken2 { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string RoomName { get; set; }
        public int Active { get; set; }
        public int Called { get; set; }
        public int Time { get; set; }
        public int Declined { get; set; }
    }
}
