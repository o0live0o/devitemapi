using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.CusMiddlewares
{
    public class CusExpetionMiddleware
    {
        private readonly RequestDelegate _next;

        public CusExpetionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException nullException)
                {
                    context.Response.ContentType = "application/text";
                    context.Response.StatusCode = 40401;
                    context.Response.WriteAsync(nullException.Message);
                }
                else
                {
                    throw ex;
                }
            }
        }
    }
}
