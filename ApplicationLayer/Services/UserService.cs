using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync(UserFilterDto filter)
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<int> CreateAsync(UserCreateDto dto)
        {
            var user = _mapper.Map<ApplicationUser>(dto);
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();
            return user.Id;
        }

        public async Task<bool> UpdateAsync(int id, UserUpdateDto dto)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            if (user == null) return false;
            
            _mapper.Map(dto, user);
            _unitOfWork.Users.Update(user);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            if (user == null) return false;
            
            _unitOfWork.Users.Delete(user);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AssignRoleAsync(int userId, int roleId)
        {
            // TODO: Implement role assignment logic
            return await Task.FromResult(true);
        }

        public async Task<bool> AddPhoneAsync(int userId, UserPhoneDto phoneDto)
        {
            // TODO: Implement phone addition logic
            return await Task.FromResult(true);
        }

        public async Task<bool> RemovePhoneAsync(int phoneId)
        {
            // TODO: Implement phone removal logic
            return await Task.FromResult(true);
        }

        public async Task<bool> AddFavoriteAsync(int userId, FavoriteDto favoriteDto)
        {
            // TODO: Implement favorite addition logic
            return await Task.FromResult(true);
        }

        public async Task<bool> RemoveFavoriteAsync(int favoriteId)
        {
            // TODO: Implement favorite removal logic
            return await Task.FromResult(true);
        }
    }
}