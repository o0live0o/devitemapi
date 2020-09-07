using Microsoft.AspNetCore.Builder;

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