using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoVotes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int OptionId { get; set; }
    }
}
