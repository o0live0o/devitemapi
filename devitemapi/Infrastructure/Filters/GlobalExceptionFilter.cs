using devitemapi.Infrastructure.ActionResult;
using devitemapi.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace devitemapi.Infrastructure.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;

        public GlobalExceptionFilter(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            var json = new JsonErrorResponse();
            json.Message = new[] { "An error occur. Try it agagin." };

            if (context.Exception is ItemException)
            {
            }

            if (_env.IsDevelopment())
            {
                json.DeveloperMessage = context.Exception;
            }
            json.TraceId = context.HttpContext.TraceIdentifier;
            context.Result = new InternalServerErrorObjectResult(json);
            context.ExceptionHandled = true;
        }

        public class JsonErrorResponse
        {
            public string[] Message { get; set; }

            public object DeveloperMessage { get; set; }

            public int Status { get; set; } = 404;

            public string Title { get; set; } = "Not Found";
            
            public string TraceId {get;set;}
        }
    }
}