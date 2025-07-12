using System;
using System.Collections.Generic;

namespace Application.DTOs
{
    public class ProjectDto
    {
        public int Id { get; set; }
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
        public List<ProjectImageDto> Images { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public bool IsFeatured { get; set; }
        public string? YoutubeVideoUrl { get; set; }
        public List<int> AssignedEmployeeIds { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ProjectCreateDto
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
        public int Type { get; set; }
        public int Status { get; set; }
        public bool IsFeatured { get; set; }
        public string? YoutubeVideoUrl { get; set; }
        public List<int> AssignedEmployeeIds { get; set; }
    }

    public class ProjectUpdateDto : ProjectCreateDto
    {
        public int Id { get; set; }
    }

    public class ProjectFilterDto
    {
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public bool? IsFeatured { get; set; }
        public string? Search { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }

    public class ProjectImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string? Caption { get; set; }
        public int Order { get; set; }
    }
} 