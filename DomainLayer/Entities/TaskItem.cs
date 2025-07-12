using System;
using Domain.Enums;
using TaskStatus = Domain.Enums.TaskStatus;

namespace Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AssignedToId { get; set; }
        public ApplicationUser AssignedTo { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime? DueDate { get; set; }
        public int? RelatedProjectId { get; set; }
        public Project? RelatedProject { get; set; }
        public int? RelatedUnitId { get; set; }
        public Unit? RelatedUnit { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? Notes { get; set; }
    }
} 