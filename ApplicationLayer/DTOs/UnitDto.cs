using System.Collections.Generic;
using System;

namespace Application.DTOs
{
    public class UnitDto
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public decimal Price { get; set; }
        public double Area { get; set; }
        public int ProjectId { get; set; }
        public int Status { get; set; }
        public int? Floor { get; set; }
        public string? Building { get; set; }
        public int NumberOfRooms { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public List<UnitImageDto> Images { get; set; }
        public List<int> FeatureIds { get; set; }
        public List<int> NoteIds { get; set; }
        public List<int> TaskIds { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class UnitCreateDto
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public decimal Price { get; set; }
        public double Area { get; set; }
        public int ProjectId { get; set; }
        public int Status { get; set; }
        public int? Floor { get; set; }
        public string? Building { get; set; }
        public int NumberOfRooms { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public List<int> FeatureIds { get; set; }
    }

    public class UnitUpdateDto : UnitCreateDto
    {
        public int Id { get; set; }
    }

    public class UnitFilterDto
    {
        public int? ProjectId { get; set; }
        public int? Status { get; set; }
        public int? Floor { get; set; }
        public string? Building { get; set; }
        public int? NumberOfRooms { get; set; }
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public double? MinArea { get; set; }
        public double? MaxArea { get; set; }
        public string? Search { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }

    public class UnitImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string? Caption { get; set; }
        public int Order { get; set; }
    }
} 