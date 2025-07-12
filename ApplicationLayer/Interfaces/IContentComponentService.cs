using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IContentComponentService
    {
        Task<ContentComponentDto> GetByIdAsync(int id);
        Task<IEnumerable<ContentComponentDto>> GetAllAsync(ContentComponentFilterDto filter);
        Task<int> CreateAsync(ContentComponentCreateDto dto);
        Task<bool> UpdateAsync(int id, ContentComponentUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }
} 