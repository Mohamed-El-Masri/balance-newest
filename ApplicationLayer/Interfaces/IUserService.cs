using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(int id);
        Task<IEnumerable<UserDto>> GetAllAsync(UserFilterDto filter);
        Task<int> CreateAsync(UserCreateDto dto);
        Task<bool> UpdateAsync(int id, UserUpdateDto dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> AssignRoleAsync(int userId, int roleId);
        Task<bool> AddPhoneAsync(int userId, UserPhoneDto phoneDto);
        Task<bool> RemovePhoneAsync(int phoneId);
        Task<bool> AddFavoriteAsync(int userId, FavoriteDto favoriteDto);
        Task<bool> RemoveFavoriteAsync(int favoriteId);
    }
} 