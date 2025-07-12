using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/employee/dashboard")]
    [Authorize(Roles = "Employee")]
    public class EmployeeDashboardController : ControllerBase
    {
        /// <summary>
        /// Get assigned projects and units for the employee.
        /// </summary>
        /// <remarks>متاح فقط للموظف.</remarks>
        [HttpGet("assigned-items")]
        public IActionResult GetAssignedItems()
        {
            // منطق إرجاع المشاريع والوحدات المعينة للموظف
            return Ok();
        }

        /// <summary>
        /// Get employee tasks.
        /// </summary>
        [HttpGet("tasks")]
        public IActionResult GetTasks()
        {
            // منطق إرجاع المهام المعينة للموظف
            return Ok();
        }
    }
} 