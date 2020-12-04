/*
 * @Author: live0x 
 * @Date: 2020-09-04 10:17:14 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-04 10:17:14 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Core.Wbl;
using devitemapi.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace devitemapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    // var context = scope.ServiceProvider.GetService<WxDbContext>();
                    // context.Database.EnsureDeleted();
                    // context.Database.Migrate();
                    if (!host.Services.GetService<IWebHostEnvironment>().IsDevelopment())
                    {
                        var spider = scope.ServiceProvider.GetService<WblSpider>();
                        spider.Enqueue();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseNLog();
    }
}
