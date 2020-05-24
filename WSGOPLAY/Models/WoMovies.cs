using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoMovies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Stars { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }
        public string Quality { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public string Source { get; set; }
        public string Iframe { get; set; }
        public string Video { get; set; }
        public int Views { get; set; }
        public string Rating { get; set; }
    }
}
