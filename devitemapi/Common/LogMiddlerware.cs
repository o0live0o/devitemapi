using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devitemapi.Common
{
    public class LogMiddlerware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LogMiddlerware> _logger;

        public LogMiddlerware(RequestDelegate next, ILogger<LogMiddlerware> logger)
        {
            this._next = next;
            this._logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {

            context.Request.EnableBuffering();
            using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8))
            {
                var reqStr = await reader.ReadToEndAsync();
                context.Request.Body.Position = 0;
               

                Stream originalBody = context.Response.Body;
                try
                {
                    using (var memStream = new MemoryStream())
                    {
                        context.Response.Body = memStream;
                        await _next.Invoke(context);
                        var request = context.Request;
                        var HttpMethod = request.Method;
                        var RequestUrl = request.Path.Value;
                        var QueryString = request.QueryString.Value;
                        var ServerIp = request.Host.Value;
                        var StatusCode = context.Response.StatusCode;
                        memStream.Position = 0;
                        var Response = new StreamReader(memStream).ReadToEnd();
                        memStream.Position = 0;
                        await memStream.CopyToAsync(originalBody);
                    }
                }
                finally
                {
                    //重新给response.body赋值，用于返回
                    context.Response.Body = originalBody;
                }
            }
        }
    }
}
