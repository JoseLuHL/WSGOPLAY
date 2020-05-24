using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoEmails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string EmailTo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
