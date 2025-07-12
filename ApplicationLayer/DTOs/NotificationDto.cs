using System;

namespace Application.DTOs
{
    public class NotificationDto
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string MessageAr { get; set; }
        public string MessageEn { get; set; }
        public int UserId { get; set; }
        public int Type { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class NotificationCreateDto
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string MessageAr { get; set; }
        public string MessageEn { get; set; }
        public int UserId { get; set; }
        public int Type { get; set; }
    }

    public class NotificationFilterDto
    {
        public int? UserId { get; set; }
        public int? Type { get; set; }
        public bool? IsRead { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
} 