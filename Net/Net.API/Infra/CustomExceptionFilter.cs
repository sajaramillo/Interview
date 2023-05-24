using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Net.API.Infra
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _hostEnvironment;

        public CustomExceptionFilter(IHostEnvironment hostEnvironment) => _hostEnvironment = hostEnvironment;

        public void OnException(ExceptionContext context)
        {
            if (!_hostEnvironment.IsDevelopment())
            {
                // Don't display exception details unless running in Development.
                return;
            }

            int? statusCode = null;
            if (context.Exception is BaseException) { statusCode = (int)((BaseException)context.Exception).StatusCode; }

            context.Result = new ContentResult
            {
                Content = context.Exception.ToString(),
                StatusCode = statusCode
            };

        }
    }
}
