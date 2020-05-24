using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoAppsPermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AppId { get; set; }
    }
}
