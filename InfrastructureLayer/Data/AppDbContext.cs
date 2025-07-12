using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ContentComponent> ContentComponents { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<ProjectFeature> ProjectFeatures { get; set; }
        public DbSet<UnitFeature> UnitFeatures { get; set; }
        public DbSet<ProjectNote> ProjectNotes { get; set; }
        public DbSet<UnitNote> UnitNotes { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPhone> UserPhones { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<InterestRequest> InterestRequests { get; set; }
    }
} 