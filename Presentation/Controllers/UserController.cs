using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get user by ID (Admins only).
        /// </summary>
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<UserDto>> GetById(int id)
        {
            var result = await _userService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        /// <summary>
        /// Get all users with filtering (Admins only).
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll([FromQuery] UserFilterDto filter)
        {
            var result = await _userService.GetAllAsync(filter);
            return Ok(result);
        }

        /// <summary>
        /// Create a new user (Admins only).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<int>> Create([FromBody] UserCreateDto dto)
        {
            var id = await _userService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        /// <summary>
        /// Update a user (Admins only).
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Update(int id, [FromBody] UserUpdateDto dto)
        {
            var updated = await _userService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Delete a user (Admins only).
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _userService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Assign role to user (Admins only).
        /// </summary>
        [HttpPost("{id}/assign-role")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> AssignRole(int id, [FromQuery] int roleId)
        {
            var result = await _userService.AssignRoleAsync(id, roleId);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Add phone to user (Admins only).
        /// </summary>
        [HttpPost("{id}/add-phone")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> AddPhone(int id, [FromBody] UserPhoneDto phoneDto)
        {
            var result = await _userService.AddPhoneAsync(id, phoneDto);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Remove phone from user (Admins only).
        /// </summary>
        [HttpDelete("phone/{phoneId}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> RemovePhone(int phoneId)
        {
            var result = await _userService.RemovePhoneAsync(phoneId);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Add favorite for user (User only).
        /// </summary>
        [HttpPost("{id}/add-favorite")]
        [Authorize(Roles = "User")]
        public async Task<ActionResult> AddFavorite(int id, [FromBody] FavoriteDto favoriteDto)
        {
            var result = await _userService.AddFavoriteAsync(id, favoriteDto);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Remove favorite for user (User only).
        /// </summary>
        [HttpDelete("favorite/{favoriteId}")]
        [Authorize(Roles = "User")]
        public async Task<ActionResult> RemoveFavorite(int favoriteId)
        {
            var result = await _userService.RemoveFavoriteAsync(favoriteId);
            if (!result) return NotFound();
            return Ok();
        }
    }
} 