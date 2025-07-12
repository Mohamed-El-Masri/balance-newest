using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// User login (JWT).
        /// </summary>
        /// <remarks>متاح للجميع (Guests).</remarks>
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] object loginDto)
        {
            // منطق تسجيل الدخول وإرجاع JWT
            return Ok(new { Token = "jwt-token" });
        }

        /// <summary>
        /// Register a new user.
        /// </summary>
        /// <remarks>متاح للجميع (Guests).</remarks>
        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult Register([FromBody] object registerDto)
        {
            // منطق تسجيل مستخدم جديد
            return Ok();
        }

        /// <summary>
        /// Google OAuth login.
        /// </summary>
        /// <remarks>متاح للجميع (Guests).</remarks>
        [HttpPost("google-login")]
        [AllowAnonymous]
        public IActionResult GoogleLogin([FromBody] object googleDto)
        {
            // منطق تسجيل الدخول عبر Google
            return Ok(new { Token = "jwt-token" });
        }

        /// <summary>
        /// Change password (للمستخدم المسجل فقط).
        /// </summary>
        [HttpPost("change-password")]
        [Authorize]
        public IActionResult ChangePassword([FromBody] object changePasswordDto)
        {
            // منطق تغيير كلمة المرور
            return Ok();
        }
    }
} 