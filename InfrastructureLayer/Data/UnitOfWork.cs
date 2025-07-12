using System.Threading.Tasks;
using Infrastructure.Data.Repositories;
using Application.Interfaces;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IProjectRepository Projects { get; }
        public IUnitRepository Units { get; }
        public IUserRepository Users { get; }
        public ITaskRepository Tasks { get; }
        public INotificationRepository Notifications { get; }
        public IContentComponentRepository ContentComponents { get; }
        public GenericRepository<Domain.Entities.Favorite> Favorites { get; }
        public GenericRepository<Domain.Entities.InterestRequest> InterestRequests { get; }
        public GenericRepository<Domain.Entities.ProjectImage> ProjectImages { get; }
        public GenericRepository<Domain.Entities.UserPhone> UserPhones { get; }
        public GenericRepository<Domain.Entities.UserRole> UserRoles { get; }
        public GenericRepository<Domain.Entities.UnitFeature> UnitFeatures { get; }
        public GenericRepository<Domain.Entities.ProjectFeature> ProjectFeatures { get; }
        public GenericRepository<Domain.Entities.ProjectNote> ProjectNotes { get; }
        public GenericRepository<Domain.Entities.UnitNote> UnitNotes { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Projects = new ProjectRepository(context);
            Units = new UnitRepository(context);
            Users = new UserRepository(context);
            Tasks = new TaskRepository(context);
            Notifications = new NotificationRepository(context);
            ContentComponents = new ContentComponentRepository(context);
            Favorites = new GenericRepository<Domain.Entities.Favorite>(context);
            InterestRequests = new GenericRepository<Domain.Entities.InterestRequest>(context);
            ProjectImages = new GenericRepository<Domain.Entities.ProjectImage>(context);
            UserPhones = new GenericRepository<Domain.Entities.UserPhone>(context);
            UserRoles = new GenericRepository<Domain.Entities.UserRole>(context);
            UnitFeatures = new GenericRepository<Domain.Entities.UnitFeature>(context);
            ProjectFeatures = new GenericRepository<Domain.Entities.ProjectFeature>(context);
            ProjectNotes = new GenericRepository<Domain.Entities.ProjectNote>(context);
            UnitNotes = new GenericRepository<Domain.Entities.UnitNote>(context);
        }

        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}