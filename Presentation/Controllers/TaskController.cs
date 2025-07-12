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
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        /// <summary>
        /// Get task by ID (Admins & Employees only).
        /// </summary>
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin,Employee")]
        public async Task<ActionResult<TaskItemDto>> GetById(int id)
        {
            var result = await _taskService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        /// <summary>
        /// Get all tasks with filtering (Admins & Employees only).
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin,Employee")]
        public async Task<ActionResult<IEnumerable<TaskItemDto>>> GetAll([FromQuery] TaskFilterDto filter)
        {
            var result = await _taskService.GetAllAsync(filter);
            return Ok(result);
        }

        /// <summary>
        /// Create a new task (Admins only).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<int>> Create([FromBody] TaskItemCreateDto dto)
        {
            var id = await _taskService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        /// <summary>
        /// Update a task (Admins & Employees only).
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin,Employee")]
        public async Task<ActionResult> Update(int id, [FromBody] TaskItemUpdateDto dto)
        {
            var updated = await _taskService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Delete a task (Admins only).
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _taskService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Assign task to employee (Admins only).
        /// </summary>
        [HttpPost("{id}/assign-employee")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> AssignToEmployee(int id, [FromQuery] int employeeId)
        {
            var result = await _taskService.AssignToEmployeeAsync(id, employeeId);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Set status for a task (Admins & Employees only).
        /// </summary>
        [HttpPost("{id}/set-status")]
        [Authorize(Roles = "Admin,SuperAdmin,Employee")]
        public async Task<ActionResult> SetStatus(int id, [FromQuery] int status)
        {
            var result = await _taskService.SetStatusAsync(id, status);
            if (!result) return NotFound();
            return Ok();
        }
    }
} 