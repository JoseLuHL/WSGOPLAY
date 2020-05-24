using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoCustompages
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public int PageType { get; set; }
    }
}
