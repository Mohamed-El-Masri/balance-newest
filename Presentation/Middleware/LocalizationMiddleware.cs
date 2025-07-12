using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;

namespace Presentation.Middleware
{
    public class LocalizationMiddleware
    {
        private readonly RequestDelegate _next;
        public LocalizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var lang = context.Request.Headers["Accept-Language"].ToString();
            if (!string.IsNullOrEmpty(lang))
            {
                try
                {
                    var culture = new CultureInfo(lang);
                    CultureInfo.CurrentCulture = culture;
                    CultureInfo.CurrentUICulture = culture;
                }
                catch { }
            }
            await _next(context);
        }
    }
} 