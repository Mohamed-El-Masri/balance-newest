using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class ContentComponent : BaseEntity
    {
        public string Key { get; set; }
        public ComponentType Type { get; set; }
        public string ValueAr { get; set; }
        public string ValueEn { get; set; }
        public int? Order { get; set; }
        public string? ImageUrl { get; set; }
    }
} 