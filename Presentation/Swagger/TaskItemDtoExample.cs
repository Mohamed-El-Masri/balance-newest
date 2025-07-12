using Application.DTOs;
using Swashbuckle.AspNetCore.Filters;
using System;

namespace Presentation.Swagger
{
    public class TaskItemDtoExample : IExamplesProvider<TaskItemDto>
    {
        public TaskItemDto GetExamples() => new TaskItemDto
        {
            Id = 1,
            Title = "مهمة متابعة مشروع",
            Description = "متابعة تقدم العمل في المشروع رقم 1",
            AssignedToId = 2,
            Status = 1,
            DueDate = DateTime.UtcNow.AddDays(7),
            RelatedProjectId = 1,
            RelatedUnitId = null,
            CompletedAt = null,
            Notes = "يرجى تحديث الحالة أسبوعياً"
        };
    }

    public class TaskItemCreateDtoExample : IExamplesProvider<TaskItemCreateDto>
    {
        public TaskItemCreateDto GetExamples() => new TaskItemCreateDto
        {
            Title = "مهمة جديدة",
            Description = "وصف المهمة الجديدة",
            AssignedToId = 3,
            Status = 0,
            DueDate = DateTime.UtcNow.AddDays(3),
            RelatedProjectId = 2,
            RelatedUnitId = 1,
            Notes = null
        };
    }

    public class TaskItemUpdateDtoExample : IExamplesProvider<TaskItemUpdateDto>
    {
        public TaskItemUpdateDto GetExamples() => new TaskItemUpdateDto
        {
            Id = 1,
            Title = "مهمة محدثة",
            Description = "تم تحديث المهمة",
            AssignedToId = 2,
            Status = 2,
            DueDate = DateTime.UtcNow.AddDays(1),
            RelatedProjectId = 1,
            RelatedUnitId = null,
            Notes = "تم تحديث الملاحظات"
        };
    }
} 