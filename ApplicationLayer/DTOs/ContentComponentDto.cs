using System;

namespace Application.DTOs
{
    public class ContentComponentDto
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public int Type { get; set; }
        public string ValueAr { get; set; }
        public string ValueEn { get; set; }
        public int? Order { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class ContentComponentCreateDto
    {
        public string Key { get; set; }
        public int Type { get; set; }
        public string ValueAr { get; set; }
        public string ValueEn { get; set; }
        public int? Order { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class ContentComponentUpdateDto : ContentComponentCreateDto
    {
        public int Id { get; set; }
    }

    public class ContentComponentFilterDto
    {
        public int? Type { get; set; }
        public string? Key { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
} 