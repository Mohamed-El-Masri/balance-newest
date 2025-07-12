using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<NotificationDto> GetByIdAsync(int id)
        {
            var notification = await _unitOfWork.Notifications.GetByIdAsync(id);
            return _mapper.Map<NotificationDto>(notification);
        }

        public async Task<IEnumerable<NotificationDto>> GetAllAsync(NotificationFilterDto filter)
        {
            var notifications = await _unitOfWork.Notifications.GetAllAsync();
            return _mapper.Map<IEnumerable<NotificationDto>>(notifications);
        }

        public async Task<int> CreateAsync(NotificationCreateDto dto)
        {
            var notification = _mapper.Map<Notification>(dto);
            await _unitOfWork.Notifications.AddAsync(notification);
            await _unitOfWork.SaveChangesAsync();
            return notification.Id;
        }

        public async Task<bool> MarkAsReadAsync(int id)
        {
            var notification = await _unitOfWork.Notifications.GetByIdAsync(id);
            if (notification == null) return false;
            
            notification.IsRead = true;
            _unitOfWork.Notifications.Update(notification);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var notification = await _unitOfWork.Notifications.GetByIdAsync(id);
            if (notification == null) return false;
            
            _unitOfWork.Notifications.Delete(notification);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
} 