using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Common
{
    public static class CustomMiddleware
    {
        public static IApplicationBuilder UseApiLog(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LogMiddlerware>();
        }

    }
}
