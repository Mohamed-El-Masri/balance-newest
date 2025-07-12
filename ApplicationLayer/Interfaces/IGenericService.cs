using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericService<TDto, TCreateDto, TUpdateDto, TFilterDto>
    {
        Task<TDto> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync(TFilterDto filter);
        Task<int> CreateAsync(TCreateDto dto);
        Task<bool> UpdateAsync(int id, TUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }
} 