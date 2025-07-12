using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/guest")]
    [AllowAnonymous]
    public class GuestController : ControllerBase
    {
        /// <summary>
        /// Browse all public projects (guest access).
        /// </summary>
        [HttpGet("projects")]
        public IActionResult BrowseProjects()
        {
            // منطق إرجاع المشاريع المتاحة للعامة
            return Ok();
        }

        /// <summary>
        /// Submit interest request as guest.
        /// </summary>
        [HttpPost("interest-request")]
        public IActionResult SubmitInterestRequest([FromBody] object request)
        {
            // منطق استقبال طلب اهتمام من ضيف
            return Ok();
        }
    }
} 