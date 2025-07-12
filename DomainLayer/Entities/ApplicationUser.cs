using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ApplicationUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? LastLoginAt { get; set; }
        public ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
        public ICollection<UserPhone> Phones { get; set; } = new List<UserPhone>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<InterestRequest> InterestRequests { get; set; } = new List<InterestRequest>();
        public ICollection<TaskItem> AssignedTasks { get; set; } = new List<TaskItem>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
} 