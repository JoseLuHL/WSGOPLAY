using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoApps
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public string AppName { get; set; }
        public string AppWebsiteUrl { get; set; }
        public string AppDescription { get; set; }
        public string AppAvatar { get; set; }
        public string AppCallbackUrl { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string Active { get; set; }
    }
}
