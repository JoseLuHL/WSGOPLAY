using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPaymentTransactions
    {
        public uint Id { get; set; }
        public uint Userid { get; set; }
        public string Kind { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDt { get; set; }
        public string Notes { get; set; }
    }
}
