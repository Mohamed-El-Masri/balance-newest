using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDto>> GetById(int id)
        {
            var result = await _projectService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDto>>> GetAll([FromQuery] ProjectFilterDto filter)
        {
            var result = await _projectService.GetAllAsync(filter);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] ProjectCreateDto dto)
        {
            var id = await _projectService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ProjectUpdateDto dto)
        {
            var updated = await _projectService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _projectService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }

        [HttpPost("{id}/assign-employees")]
        public async Task<ActionResult> AssignEmployees(int id, [FromBody] List<int> employeeIds)
        {
            var result = await _projectService.AssignEmployeesAsync(id, employeeIds);
            if (!result) return NotFound();
            return Ok();
        }

        [HttpPost("{id}/set-featured")]
        public async Task<ActionResult> SetFeatured(int id, [FromQuery] bool isFeatured)
        {
            var result = await _projectService.SetFeaturedAsync(id, isFeatured);
            if (!result) return NotFound();
            return Ok();
        }

        [HttpPost("{id}/add-image")]
        public async Task<ActionResult> AddImage(int id, [FromBody] ProjectImageDto imageDto)
        {
            var result = await _projectService.AddProjectImageAsync(id, imageDto);
            if (!result) return NotFound();
            return Ok();
        }

        [HttpDelete("image/{imageId}")]
        public async Task<ActionResult> RemoveImage(int imageId)
        {
            var result = await _projectService.RemoveProjectImageAsync(imageId);
            if (!result) return NotFound();
            return Ok();
        }
    }
} 