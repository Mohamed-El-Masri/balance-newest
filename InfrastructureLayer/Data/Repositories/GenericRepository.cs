using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Data.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _dbSet.ToListAsync();
        public virtual async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);
        public virtual void Update(TEntity entity) => _dbSet.Update(entity);
        public virtual void Delete(TEntity entity) => _dbSet.Remove(entity);
    }
} 