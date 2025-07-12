namespace Domain.Entities
{
    public class ProjectNote : BaseEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string Note { get; set; }
        public int? EmployeeId { get; set; }
        public ApplicationUser? Employee { get; set; }
    }
} 