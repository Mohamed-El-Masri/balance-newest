using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;

namespace Infrastructure.Data.Repositories
{
    public class ContentComponentRepository : GenericRepository<ContentComponent>, IContentComponentRepository
    {
        public ContentComponentRepository(AppDbContext context) : base(context) { }
        // Add content component-specific methods here
    }
}
