using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/user/dashboard")]
    [Authorize(Roles = "User,Employee,Admin,SuperAdmin")]
    public class UserDashboardController : ControllerBase
    {
        /// <summary>
        /// Get user profile and favorites.
        /// </summary>
        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            // منطق إرجاع بيانات البروفايل والمفضلات
            return Ok();
        }

        /// <summary>
        /// Get user's interest requests.
        /// </summary>
        [HttpGet("interest-requests")]
        public IActionResult GetInterestRequests()
        {
            // منطق إرجاع طلبات الاهتمام الخاصة بالمستخدم
            return Ok();
        }
    }
} 