using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class BankReceipts
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Mode { get; set; }
        public uint Approved { get; set; }
        public string ReceiptFile { get; set; }
        public DateTime CreatedAt { get; set; }
        public uint ApprovedAt { get; set; }
    }
}
