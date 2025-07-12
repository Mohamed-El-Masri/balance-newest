using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ITaskService
    {
        Task<TaskItemDto> GetByIdAsync(int id);
        Task<IEnumerable<TaskItemDto>> GetAllAsync(TaskFilterDto filter);
        Task<int> CreateAsync(TaskItemCreateDto dto);
        Task<bool> UpdateAsync(int id, TaskItemUpdateDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> AssignToEmployeeAsync(int taskId, int employeeId);
        Task<bool> SetStatusAsync(int taskId, int status);
    }
} 