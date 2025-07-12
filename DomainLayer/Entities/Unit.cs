using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Unit : BaseEntity
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public decimal Price { get; set; }
        public double Area { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public UnitStatus Status { get; set; }
        public int? Floor { get; set; }
        public string? Building { get; set; }
        public int NumberOfRooms { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public ICollection<UnitFeature> Features { get; set; } = new List<UnitFeature>();
        public ICollection<UnitNote> Notes { get; set; } = new List<UnitNote>();
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
} 