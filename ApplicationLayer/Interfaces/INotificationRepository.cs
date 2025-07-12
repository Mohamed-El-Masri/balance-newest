using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface INotificationRepository
    {
        Task<Notification?> GetByIdAsync(int id);
        Task<IEnumerable<Notification>> GetAllAsync();
        Task AddAsync(Notification entity);
        void Update(Notification entity);
        void Delete(Notification entity);
    }
}
