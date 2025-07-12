using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface INotificationService
    {
        Task<NotificationDto> GetByIdAsync(int id);
        Task<IEnumerable<NotificationDto>> GetAllAsync(NotificationFilterDto filter);
        Task<int> CreateAsync(NotificationCreateDto dto);
        Task<bool> MarkAsReadAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
} 