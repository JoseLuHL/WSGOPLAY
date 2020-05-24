using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoGamesPlayers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public int LastPlay { get; set; }
        public string Active { get; set; }
    }
}
