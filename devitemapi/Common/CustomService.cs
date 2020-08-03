using devitemapi.Infrastructure.Services;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace devitemapi.Common
{
    public static class CustomService
    {
        public static void AddScoped(this IServiceCollection services,Assembly @interface,Assembly @imlpement)
        {
            var @interfaces = @interface.GetTypes().Where(type => type.IsInterface);
            var @implements = imlpement.GetTypes();
            foreach (var item in @interfaces)
            {
                var type = @implements.Where(t => item.IsAssignableFrom(t)).FirstOrDefault();
                if(type != null)
                    services.AddScoped(item, type);
            }
        }

        public static void AddCusService(this IServiceCollection services)
        {
            services.AddScoped<IActionService, ActionService>();
        }
    }
}
