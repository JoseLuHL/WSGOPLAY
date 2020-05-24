using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoProfilefields
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public string Placement { get; set; }
        public int RegistrationPage { get; set; }
        public int ProfilePage { get; set; }
        public string SelectType { get; set; }
        public string Active { get; set; }
    }
}
