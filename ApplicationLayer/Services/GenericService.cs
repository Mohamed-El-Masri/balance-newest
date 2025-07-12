using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Services
{
    public class GenericService<TDto, TCreateDto, TUpdateDto, TFilterDto> : IGenericService<TDto, TCreateDto, TUpdateDto, TFilterDto>
    {
        public GenericService(/* inject dependencies here */)
        {
        }

        public Task<int> CreateAsync(TCreateDto dto) => throw new System.NotImplementedException();
        public Task<bool> DeleteAsync(int id) => throw new System.NotImplementedException();
        public Task<IEnumerable<TDto>> GetAllAsync(TFilterDto filter) => throw new System.NotImplementedException();
        public Task<TDto> GetByIdAsync(int id) => throw new System.NotImplementedException();
        public Task<bool> UpdateAsync(int id, TUpdateDto dto) => throw new System.NotImplementedException();
    }
} 