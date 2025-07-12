using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Presentation.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var response = new
            {
                Message = "An unexpected error occurred.",
                Details = context.Exception.Message
            };
            context.Result = new ObjectResult(response)
            {
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
} 