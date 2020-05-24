using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoVerificationRequests
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public string Passport { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public int Seen { get; set; }
    }
}
