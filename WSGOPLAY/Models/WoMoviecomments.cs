using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoMoviecomments
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public int Posted { get; set; }
    }
}
