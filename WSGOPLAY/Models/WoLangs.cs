using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoLangs
    {
        public int Id { get; set; }
        public string LangKey { get; set; }
        public string Type { get; set; }
        public string English { get; set; }
        public string Spanish { get; set; }
    }
}
