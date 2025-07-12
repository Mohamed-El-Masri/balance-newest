using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProjectService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProjectDto> GetByIdAsync(int id)
        {
            var project = await _unitOfWork.Projects.GetByIdAsync(id);
            return _mapper.Map<ProjectDto>(project);
        }

        public async Task<IEnumerable<ProjectDto>> GetAllAsync(ProjectFilterDto filter)
        {
            var projects = await _unitOfWork.Projects.GetAllAsync();
            return _mapper.Map<IEnumerable<ProjectDto>>(projects);
        }

        public async Task<int> CreateAsync(ProjectCreateDto dto)
        {
            var project = _mapper.Map<Project>(dto);
            await _unitOfWork.Projects.AddAsync(project);
            await _unitOfWork.SaveChangesAsync();
            return project.Id;
        }

        public async Task<bool> UpdateAsync(int id, ProjectUpdateDto dto)
        {
            var project = await _unitOfWork.Projects.GetByIdAsync(id);
            if (project == null) return false;
            
            _mapper.Map(dto, project);
            _unitOfWork.Projects.Update(project);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var project = await _unitOfWork.Projects.GetByIdAsync(id);
            if (project == null) return false;
            
            _unitOfWork.Projects.Delete(project);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AssignEmployeesAsync(int projectId, List<int> employeeIds)
        {
            // TODO: Implement employee assignment logic
            return await Task.FromResult(true);
        }

        public async Task<bool> SetFeaturedAsync(int projectId, bool isFeatured)
        {
            var project = await _unitOfWork.Projects.GetByIdAsync(projectId);
            if (project == null) return false;
            
            project.IsFeatured = isFeatured;
            _unitOfWork.Projects.Update(project);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddProjectImageAsync(int projectId, ProjectImageDto imageDto)
        {
            // TODO: Implement project image addition logic
            return await Task.FromResult(true);
        }

        public async Task<bool> RemoveProjectImageAsync(int imageId)
        {
            // TODO: Implement project image removal logic
            return await Task.FromResult(true);
        }
    }
} 