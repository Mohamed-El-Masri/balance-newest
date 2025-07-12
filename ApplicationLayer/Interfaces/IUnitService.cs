using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IUnitService
    {
        Task<UnitDto> GetByIdAsync(int id);
        Task<IEnumerable<UnitDto>> GetAllAsync(UnitFilterDto filter);
        Task<int> CreateAsync(UnitCreateDto dto);
        Task<bool> UpdateAsync(int id, UnitUpdateDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> AssignEmployeeAsync(int unitId, int employeeId);
        Task<bool> AddUnitImageAsync(int unitId, UnitImageDto imageDto);
        Task<bool> RemoveUnitImageAsync(int imageId);
    }
} 