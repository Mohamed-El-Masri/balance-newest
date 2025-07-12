using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectDto> GetByIdAsync(int id);
        Task<IEnumerable<ProjectDto>> GetAllAsync(ProjectFilterDto filter);
        Task<int> CreateAsync(ProjectCreateDto dto);
        Task<bool> UpdateAsync(int id, ProjectUpdateDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> AssignEmployeesAsync(int projectId, List<int> employeeIds);
        Task<bool> SetFeaturedAsync(int projectId, bool isFeatured);
        Task<bool> AddProjectImageAsync(int projectId, ProjectImageDto imageDto);
        Task<bool> RemoveProjectImageAsync(int imageId);
        // ... أي عمليات إضافية مثل الإحصائيات أو التفعيل/التعطيل
    }
} 