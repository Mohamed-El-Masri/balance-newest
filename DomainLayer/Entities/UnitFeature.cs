namespace Domain.Entities
{
    public class UnitFeature : BaseEntity
    {
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string? IconUrl { get; set; }
    }
} 