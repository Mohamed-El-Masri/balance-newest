namespace Domain.Entities
{
    public class Favorite : BaseEntity
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
        public int? UnitId { get; set; }
        public Unit? Unit { get; set; }
    }
} 