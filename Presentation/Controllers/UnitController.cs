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
    public class UnitController : ControllerBase
    {
        private readonly IUnitService _unitService;
        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        /// <summary>
        /// Get unit by ID (متاح للجميع).
        /// </summary>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<UnitDto>> GetById(int id)
        {
            var result = await _unitService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        /// <summary>
        /// Get all units with filtering (متاح للجميع).
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<UnitDto>>> GetAll([FromQuery] UnitFilterDto filter)
        {
            var result = await _unitService.GetAllAsync(filter);
            return Ok(result);
        }

        /// <summary>
        /// Create a new unit (Admins only).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<int>> Create([FromBody] UnitCreateDto dto)
        {
            var id = await _unitService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        /// <summary>
        /// Update a unit (Admins only).
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Update(int id, [FromBody] UnitUpdateDto dto)
        {
            var updated = await _unitService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Delete a unit (Admins only).
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _unitService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Assign employee to a unit (Admins only).
        /// </summary>
        [HttpPost("{id}/assign-employee")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> AssignEmployee(int id, [FromQuery] int employeeId)
        {
            var result = await _unitService.AssignEmployeeAsync(id, employeeId);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Add image to unit (Admins only).
        /// </summary>
        [HttpPost("{id}/add-image")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> AddImage(int id, [FromBody] UnitImageDto imageDto)
        {
            var result = await _unitService.AddUnitImageAsync(id, imageDto);
            if (!result) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Remove image from unit (Admins only).
        /// </summary>
        [HttpDelete("image/{imageId}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> RemoveImage(int imageId)
        {
            var result = await _unitService.RemoveUnitImageAsync(imageId);
            if (!result) return NotFound();
            return Ok();
        }
    }
} 