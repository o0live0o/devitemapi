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

            json.Message =  "An error occur. Try it agagin.";
            json.TraceId = context.HttpContext.TraceIdentifier;

            if (context.Exception is ItemException itemException)
            {
                json.Message = itemException.Message;
                json.Status = (int)itemException.ItemCode;
                json.Title = itemException.ItemCode.ToString();
                context.Result = new ItemObjectResult(json,(int)itemException.ItemCode);
            }
            else //if (_env.IsDevelopment())
            {
                json.DeveloperMessage = context.Exception;
                context.Result = new InternalServerErrorObjectResult(json);
            }
            // else
            // {
            //     json.Message += "\r\nunhandled exception";
            // }
            context.ExceptionHandled = true;
        }

        public class JsonErrorResponse
        {
            public JsonErrorResponse()
            {
                
            }
            public JsonErrorResponse(int status)
            {
                
            }

            public string Message { get; set; }

            public object DeveloperMessage { get; set; }

            public int Status { get; set; } = 500;

            public string Title { get; set; } = "Internal Server Error";
            
            public string TraceId {get;set;}
        }
    }
}