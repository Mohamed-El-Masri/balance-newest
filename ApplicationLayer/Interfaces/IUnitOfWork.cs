using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IProjectRepository Projects { get; }
        IUnitRepository Units { get; }
        ITaskRepository Tasks { get; }
        INotificationRepository Notifications { get; }
        IContentComponentRepository ContentComponents { get; }
        Task<int> SaveChangesAsync();
    }
}
