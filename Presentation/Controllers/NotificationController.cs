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
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        /// <summary>
        /// Get notification by ID (Admins & Users only).
        /// </summary>
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin,User")]
        public async Task<ActionResult<NotificationDto>> GetById(int id)
        {
            var result = await _notificationService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        /// <summary>
        /// Get all notifications with filtering (Admins & Users only).
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin,User")]
        public async Task<ActionResult<IEnumerable<NotificationDto>>> GetAll([FromQuery] NotificationFilterDto filter)
        {
            var result = await _notificationService.GetAllAsync(filter);
            return Ok(result);
        }

        /// <summary>
        /// Create a new notification (Admins only).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<int>> Create([FromBody] NotificationCreateDto dto)
        {
            var id = await _notificationService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        /// <summary>
        /// Mark notification as read (User only).
        /// </summary>
        [HttpPost("{id}/mark-as-read")]
        [Authorize(Roles = "User")]
        public async Task<ActionResult> MarkAsRead(int id)
        {
            var result = await _notificationService.MarkAsReadAsync(id);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Delete a notification (Admins only).
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _notificationService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
} 