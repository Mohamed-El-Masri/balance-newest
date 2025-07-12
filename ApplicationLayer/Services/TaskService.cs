using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TaskService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TaskItemDto> GetByIdAsync(int id)
        {
            var task = await _unitOfWork.Tasks.GetByIdAsync(id);
            return _mapper.Map<TaskItemDto>(task);
        }

        public async Task<IEnumerable<TaskItemDto>> GetAllAsync(TaskFilterDto filter)
        {
            var tasks = await _unitOfWork.Tasks.GetAllAsync();
            return _mapper.Map<IEnumerable<TaskItemDto>>(tasks);
        }

        public async Task<int> CreateAsync(TaskItemCreateDto dto)
        {
            var task = _mapper.Map<TaskItem>(dto);
            await _unitOfWork.Tasks.AddAsync(task);
            await _unitOfWork.SaveChangesAsync();
            return task.Id;
        }

        public async Task<bool> UpdateAsync(int id, TaskItemUpdateDto dto)
        {
            var task = await _unitOfWork.Tasks.GetByIdAsync(id);
            if (task == null) return false;
            
            _mapper.Map(dto, task);
            _unitOfWork.Tasks.Update(task);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var task = await _unitOfWork.Tasks.GetByIdAsync(id);
            if (task == null) return false;
            
            _unitOfWork.Tasks.Delete(task);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AssignToEmployeeAsync(int taskId, int employeeId)
        {
            var task = await _unitOfWork.Tasks.GetByIdAsync(taskId);
            if (task == null) return false;
            
            task.AssignedToId = employeeId;
            _unitOfWork.Tasks.Update(task);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> SetStatusAsync(int taskId, int status)
        {
            var task = await _unitOfWork.Tasks.GetByIdAsync(taskId);
            if (task == null) return false;
            
            task.Status = (Domain.Enums.TaskStatus)status;
            _unitOfWork.Tasks.Update(task);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
} 