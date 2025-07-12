using Domain.Enums;

namespace Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public RoleType Role { get; set; }
    }
} 