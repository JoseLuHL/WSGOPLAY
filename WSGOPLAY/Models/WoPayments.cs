using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPayments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
    }
}
