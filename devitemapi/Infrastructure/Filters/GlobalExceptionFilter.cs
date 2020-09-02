using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            if (_env.IsDevelopment())
            {
                json.DeveloperMessage = context.Exception;
            }

        }

        public class JsonErrorResponse
        {
            public string[] Message { get; set; }

            public object DeveloperMessage { get; set; }
        }
    }
}
