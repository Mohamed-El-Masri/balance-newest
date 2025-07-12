using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUnitRepository
    {
        Task<Unit?> GetByIdAsync(int id);
        Task<IEnumerable<Unit>> GetAllAsync();
        Task AddAsync(Unit entity);
        void Update(Unit entity);
        void Delete(Unit entity);
    }
}
