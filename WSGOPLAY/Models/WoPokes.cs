using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPokes
    {
        public int Id { get; set; }
        public int ReceivedUserId { get; set; }
        public int SendUserId { get; set; }
        public DateTime Dt { get; set; }
    }
}
