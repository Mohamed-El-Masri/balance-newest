using System;
using System.Collections.Generic;

namespace Application.DTOs
{
    public class TaskItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AssignedToId { get; set; }
        public int Status { get; set; }
        public DateTime? DueDate { get; set; }
        public int? RelatedProjectId { get; set; }
        public int? RelatedUnitId { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? Notes { get; set; }
    }

    public class TaskItemCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AssignedToId { get; set; }
        public int Status { get; set; }
        public DateTime? DueDate { get; set; }
        public int? RelatedProjectId { get; set; }
        public int? RelatedUnitId { get; set; }
        public string? Notes { get; set; }
    }

    public class TaskItemUpdateDto : TaskItemCreateDto
    {
        public int Id { get; set; }
    }

    public class TaskFilterDto
    {
        public int? AssignedToId { get; set; }
        public int? Status { get; set; }
        public int? RelatedProjectId { get; set; }
        public int? RelatedUnitId { get; set; }
        public DateTime? DueBefore { get; set; }
        public DateTime? DueAfter { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
} 