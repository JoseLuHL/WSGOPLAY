using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoGames
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameAvatar { get; set; }
        public string GameLink { get; set; }
        public string Active { get; set; }
        public int Time { get; set; }
    }
}
