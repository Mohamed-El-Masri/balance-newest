using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class ContentComponentService : IContentComponentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContentComponentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ContentComponentDto> GetByIdAsync(int id)
        {
            var component = await _unitOfWork.ContentComponents.GetByIdAsync(id);
            return _mapper.Map<ContentComponentDto>(component);
        }

        public async Task<IEnumerable<ContentComponentDto>> GetAllAsync(ContentComponentFilterDto filter)
        {
            var components = await _unitOfWork.ContentComponents.GetAllAsync();
            return _mapper.Map<IEnumerable<ContentComponentDto>>(components);
        }

        public async Task<int> CreateAsync(ContentComponentCreateDto dto)
        {
            var component = _mapper.Map<ContentComponent>(dto);
            await _unitOfWork.ContentComponents.AddAsync(component);
            await _unitOfWork.SaveChangesAsync();
            return component.Id;
        }

        public async Task<bool> UpdateAsync(int id, ContentComponentUpdateDto dto)
        {
            var component = await _unitOfWork.ContentComponents.GetByIdAsync(id);
            if (component == null) return false;
            
            _mapper.Map(dto, component);
            _unitOfWork.ContentComponents.Update(component);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var component = await _unitOfWork.ContentComponents.GetByIdAsync(id);
            if (component == null) return false;
            
            _unitOfWork.ContentComponents.Delete(component);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
} 