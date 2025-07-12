using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/admin/dashboard")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class AdminDashboardController : ControllerBase
    {
        /// <summary>
        /// Get admin dashboard analytics and summary data.
        /// </summary>
        /// <remarks>متاح فقط للأدمن والسوبر أدمن.</remarks>
        [HttpGet("analytics")]
        public IActionResult GetAnalytics()
        {
            // منطق إرجاع بيانات إحصائية ولوحة التحكم
            return Ok(new { Projects = 100, Users = 50, Units = 200 });
        }

        /// <summary>
        /// Get all users for management.
        /// </summary>
        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            // منطق إرجاع جميع المستخدمين (للتوثيق فقط)
            return Ok();
        }
    }
} 