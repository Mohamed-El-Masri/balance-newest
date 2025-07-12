using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileUploadController : ControllerBase
    {
        /// <summary>
        /// Upload an image to Cloudinary (Admins & Employees only).
        /// </summary>
        [HttpPost("upload")]
        [Authorize(Roles = "Admin,SuperAdmin,Employee")]
        public IActionResult UploadImage([FromForm] object file)
        {
            // منطق رفع الصورة إلى Cloudinary
            return Ok(new { Url = "https://cloudinary.com/image.jpg" });
        }

        /// <summary>
        /// Delete an image from Cloudinary (Admins only).
        /// </summary>
        [HttpDelete("delete")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public IActionResult DeleteImage([FromQuery] string publicId)
        {
            // منطق حذف الصورة من Cloudinary
            return Ok();
        }
    }
} 