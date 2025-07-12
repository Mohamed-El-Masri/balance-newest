using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Entities
{
    public class Project : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string LocationAr { get; set; }
        public string LocationEn { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int NumberOfBaths { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int Cost { get; set; }
        public long Area { get; set; }
        public string DirectLink { get; set; }
        public string AreaUnitAr { get; set; }
        public string AreaUnitEn { get; set; }
        public string? MainImageUrl { get; set; }
        public ICollection<ProjectImage> Images { get; set; } = new List<ProjectImage>();
        public ProjectType Type { get; set; }
        public ProjectStatus Status { get; set; }
        public bool IsFeatured { get; set; } = false;
        public string? YoutubeVideoUrl { get; set; }
        public ICollection<Unit> Units { get; set; } = new List<Unit>();
        public ICollection<ProjectFeature> Features { get; set; } = new List<ProjectFeature>();
        public ICollection<ProjectNote> Notes { get; set; } = new List<ProjectNote>();
        public ICollection<ApplicationUser> AssignedEmployees { get; set; } = new List<ApplicationUser>();
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
