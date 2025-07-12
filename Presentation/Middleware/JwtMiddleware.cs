using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Presentation.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // سيتم إضافة منطق JWT لاحقاً
            await _next(context);
        }
    }
} 