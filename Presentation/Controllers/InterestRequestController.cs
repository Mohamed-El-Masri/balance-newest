using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterestRequestController : ControllerBase
    {
        /// <summary>
        /// Submit an interest request for a project or unit (متاح للجميع).
        /// </summary>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult SubmitInterest([FromBody] object interestDto)
        {
            // منطق استقبال طلب الاهتمام
            return Ok();
        }

        /// <summary>
        /// Get all interest requests (Admins only).
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public IActionResult GetAll()
        {
            // منطق إرجاع جميع الطلبات
            return Ok();
        }
    }
} 