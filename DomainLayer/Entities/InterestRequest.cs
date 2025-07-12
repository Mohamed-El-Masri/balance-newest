using System;

namespace Domain.Entities
{
    public class InterestRequest : BaseEntity
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? UnitId { get; set; }
        public Unit? Unit { get; set; }
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
        public string Notes { get; set; }
        public int? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
} 