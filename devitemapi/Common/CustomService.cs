﻿using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace devitemapi.Common
{
    public static class CustomService
    {
        public static void AddScoped(this IServiceCollection services, Assembly @interface, Assembly @imlpement)
        {
            var @interfaces = @interface.GetTypes().Where(type => type.IsInterface);
            var @implements = imlpement.GetTypes();
            foreach (var item in @interfaces)
            {
                var type = @implements.Where(t => item.IsAssignableFrom(t)).FirstOrDefault();
                if (type != null)
                    services.AddScoped(item, type);
            }
        }

        public static void AddCusService(this IServiceCollection services)
        {
            var _interfaceNS = "devitemapi.Services.Interface";
            var _impleNS = "devitemapi.Services";

            var @interfaces = Assembly.GetExecutingAssembly().GetTypes().Where(type => _interfaceNS.Equals(type.Namespace) && type.IsInterface);
            var @implements = Assembly.GetExecutingAssembly().GetTypes().Where(type => _impleNS.Equals(type.Namespace));

            foreach (var item in @interfaces)
            {
                var type = @implements.Where(t => item.IsAssignableFrom(t)).FirstOrDefault();
                if (type != null)
                    services.AddScoped(item, type);
            }
        }

        public static void AddCusRepository(this IServiceCollection services)
        {
            var _interfaceNS = "devitemapi.Infrastructure.Repository.Interface";
            var _impleNS = "devitemapi.Infrastructure.Repository";

            var @interfaces = Assembly.GetExecutingAssembly().GetTypes().Where(type => _interfaceNS.Equals(type.Namespace) && type.IsInterface);
            var @implements = Assembly.GetExecutingAssembly().GetTypes().Where(type => _impleNS.Equals(type.Namespace));

            foreach (var item in @interfaces)
            {
                var type = @implements.Where(t => item.IsAssignableFrom(t)).FirstOrDefault();
                if (type != null)
                    services.AddScoped(item, type);
            }
        }

        //public static void Trace(this ILogger logger, string message, params object[] args)
        //{
        //    ApiLogger apiLogger = new ApiLogger();
        //    apiLogger.Debug();
        //}
    }
}