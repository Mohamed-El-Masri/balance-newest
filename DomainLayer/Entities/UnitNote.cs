namespace Domain.Entities
{
    public class UnitNote : BaseEntity
    {
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public string Note { get; set; }
        public int? EmployeeId { get; set; }
        public ApplicationUser? Employee { get; set; }
    }
} 