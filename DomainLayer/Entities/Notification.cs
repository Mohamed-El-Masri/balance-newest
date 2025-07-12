using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class Notification : BaseEntity
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string MessageAr { get; set; }
        public string MessageEn { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public NotificationType Type { get; set; }
        public bool IsRead { get; set; }
    }
} 