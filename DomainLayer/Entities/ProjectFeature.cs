namespace Domain.Entities
{
    public class ProjectFeature : BaseEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string? IconUrl { get; set; } // يمكن أن تكون FontAwesome أو صورة
    }
} 