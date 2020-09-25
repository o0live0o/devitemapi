/*
 * @Author: live0x 
 * @Date: 2020-09-25 16:55:17 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-25 16:55:17 
 */
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
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
            // try
            // {
            await _next.Invoke(context);
            // }
            // catch (Exception ex)
            // {
            //     if (ex is ArgumentNullException nullException)
            //     {
            //         context.Response.ContentType = "application/text";
            //         context.Response.StatusCode = 40401;
            //         await context.Response.WriteAsync(nullException.Message);
            //     }
            //     else
            //     {
            //         throw ex;
            //     }
            // }
        }
    }
}