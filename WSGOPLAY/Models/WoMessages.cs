using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoMessages
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int GroupId { get; set; }
        public int ToId { get; set; }
        public string Text { get; set; }
        public string Media { get; set; }
        public string MediaFileName { get; set; }
        public string MediaFileNames { get; set; }
        public int Time { get; set; }
        public int Seen { get; set; }
        public string DeletedOne { get; set; }
        public string DeletedTwo { get; set; }
        public int SentPush { get; set; }
        public string NotificationId { get; set; }
        public string TypeTwo { get; set; }
        public string Stickers { get; set; }
    }
}
