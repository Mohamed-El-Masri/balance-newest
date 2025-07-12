using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;

namespace Infrastructure.Data.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context) { }
        // Add project-specific methods here
    }
} 