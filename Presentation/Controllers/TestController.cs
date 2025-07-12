using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "التطبيق يعمل بنجاح!", timestamp = DateTime.Now });
        }
        
        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new { status = "Healthy", version = "1.0.0" });
        }
    }
}
