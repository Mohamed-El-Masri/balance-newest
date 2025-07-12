using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class UnitService : IUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UnitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UnitDto> GetByIdAsync(int id)
        {
            var unit = await _unitOfWork.Units.GetByIdAsync(id);
            return _mapper.Map<UnitDto>(unit);
        }

        public async Task<IEnumerable<UnitDto>> GetAllAsync(UnitFilterDto filter)
        {
            var units = await _unitOfWork.Units.GetAllAsync();
            return _mapper.Map<IEnumerable<UnitDto>>(units);
        }

        public async Task<int> CreateAsync(UnitCreateDto dto)
        {
            var unit = _mapper.Map<Unit>(dto);
            await _unitOfWork.Units.AddAsync(unit);
            await _unitOfWork.SaveChangesAsync();
            return unit.Id;
        }

        public async Task<bool> UpdateAsync(int id, UnitUpdateDto dto)
        {
            var unit = await _unitOfWork.Units.GetByIdAsync(id);
            if (unit == null) return false;
            
            _mapper.Map(dto, unit);
            _unitOfWork.Units.Update(unit);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var unit = await _unitOfWork.Units.GetByIdAsync(id);
            if (unit == null) return false;
            
            _unitOfWork.Units.Delete(unit);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AssignEmployeeAsync(int unitId, int employeeId)
        {
            // TODO: Implement employee assignment logic
            return await Task.FromResult(true);
        }

        public async Task<bool> AddUnitImageAsync(int unitId, UnitImageDto imageDto)
        {
            // TODO: Implement unit image addition logic
            return await Task.FromResult(true);
        }

        public async Task<bool> RemoveUnitImageAsync(int imageId)
        {
            // TODO: Implement unit image removal logic
            return await Task.FromResult(true);
        }
    }
} 