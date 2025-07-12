namespace Domain.Entities
{
    public class ProjectImage : BaseEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string ImageUrl { get; set; }
        public string? Caption { get; set; }
        public int Order { get; set; } = 0;
    }
}