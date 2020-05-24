using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoManagePro
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public int FeaturedMember { get; set; }
        public int ProfileVisitors { get; set; }
        public int LastSeen { get; set; }
        public int VerifiedBadge { get; set; }
        public int PostsPromotion { get; set; }
        public int PagesPromotion { get; set; }
        public string Discount { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public int Time { get; set; }
    }
}
