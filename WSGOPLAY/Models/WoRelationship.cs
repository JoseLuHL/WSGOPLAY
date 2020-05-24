using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoRelationship
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int Relationship { get; set; }
        public string Active { get; set; }
    }
}
