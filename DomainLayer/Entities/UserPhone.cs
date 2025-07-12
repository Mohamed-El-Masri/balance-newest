namespace Domain.Entities
{
    public class UserPhone : BaseEntity
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; } = false;
    }
} 