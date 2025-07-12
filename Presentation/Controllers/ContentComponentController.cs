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
    public class ContentComponentController : ControllerBase
    {
        private readonly IContentComponentService _contentService;
        public ContentComponentController(IContentComponentService contentService)
        {
            _contentService = contentService;
        }

        /// <summary>
        /// Get content component by ID (Admins only).
        /// </summary>
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<ContentComponentDto>> GetById(int id)
        {
            var result = await _contentService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        /// <summary>
        /// Get all content components with filtering (Admins only).
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<IEnumerable<ContentComponentDto>>> GetAll([FromQuery] ContentComponentFilterDto filter)
        {
            var result = await _contentService.GetAllAsync(filter);
            return Ok(result);
        }

        /// <summary>
        /// Create a new content component (Admins only).
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<int>> Create([FromBody] ContentComponentCreateDto dto)
        {
            var id = await _contentService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        /// <summary>
        /// Update a content component (Admins only).
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Update(int id, [FromBody] ContentComponentUpdateDto dto)
        {
            var updated = await _contentService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Delete a content component (Admins only).
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _contentService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
} 