using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IContentComponentRepository
    {
        Task<ContentComponent?> GetByIdAsync(int id);
        Task<IEnumerable<ContentComponent>> GetAllAsync();
        Task AddAsync(ContentComponent entity);
        void Update(ContentComponent entity);
        void Delete(ContentComponent entity);
    }
}
