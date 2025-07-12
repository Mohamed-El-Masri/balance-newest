using Application.DTOs;
using Swashbuckle.AspNetCore.Filters;
using System;

namespace Presentation.Swagger
{
    public class NotificationDtoExample : IExamplesProvider<NotificationDto>
    {
        public NotificationDto GetExamples() => new NotificationDto
        {
            Id = 1,
            TitleAr = "تنبيه جديد",
            TitleEn = "New Notification",
            MessageAr = "لديك مهمة جديدة",
            MessageEn = "You have a new task",
            UserId = 2,
            Type = 1,
            IsRead = false,
            CreatedAt = DateTime.UtcNow
        };
    }

    public class NotificationCreateDtoExample : IExamplesProvider<NotificationCreateDto>
    {
        public NotificationCreateDto GetExamples() => new NotificationCreateDto
        {
            TitleAr = "تنبيه مهم",
            TitleEn = "Important Notification",
            MessageAr = "يرجى مراجعة المشروع",
            MessageEn = "Please review the project",
            UserId = 2,
            Type = 2
        };
    }
} 