using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoMoviecommentreplies
    {
        public int Id { get; set; }
        public int CommId { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Posted { get; set; }
    }
}
