using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoCodes
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string AppId { get; set; }
        public int UserId { get; set; }
        public int Time { get; set; }
    }
}
