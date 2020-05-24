using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoBlogmoviedislikes
    {
        public int Id { get; set; }
        public int BlogCommId { get; set; }
        public int BlogCommreplyId { get; set; }
        public int MovieCommId { get; set; }
        public int MovieCommreplyId { get; set; }
        public int UserId { get; set; }
        public int BlogId { get; set; }
        public int MovieId { get; set; }
    }
}
