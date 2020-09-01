using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Common;
using devitemapi.Entity;
using devitemapi.Infrastructure.CusMiddlewares;
using devitemapi.Infrastructure.Log;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLog.Extensions.Logging;
using Swashbuckle.AspNetCore.Filters;

namespace devitemapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o =>
           o.AddPolicy("CorsPolicy",
              builder => builder
            .AllowAnyHeader()
            .AllowAnyMethod()
             .SetIsOriginAllowed(_ => true)
             //.AllowCredentials()
             ));

            services.AddControllers();


            //RedisClient.GetRedisClient.Init(Configuration);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddCusService();

            services.AddCusRepository();

            services.AddSingleton<IApiLogger, ApiLogger>();

            services.AddDbContext<DevDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("MySqlStr"));
            });

            AppConfig.Config = Configuration.GetSection("AppConfig").Get<ConfigEntity>();

            services.AddCors();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options=> {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidAudience = AppConfig.Config.Audience,
                    ValidIssuer = AppConfig.Config.Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppConfig.Config.JwtSecurityKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Version = "V1.0",
                    Title = "IetmApi"
                });

                var xmlPath = Path.Combine(System.AppContext.BaseDirectory, "devitemapi.xml");
                options.IncludeXmlComments(xmlPath, true);

                options.OperationFilter<AddResponseHeadersFilter>();
                options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                options.OperationFilter<SecurityRequirementsOperationFilter>();

                //开启oauth2安全描述
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {  
                    Description = "JWT授权 Bearer {tokem}",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    //Scheme = "basic",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            NLog.LogManager.LoadConfiguration("nlog.config").GetCurrentClassLogger();
            NLog.LogManager.Configuration.Variables["connectionString"] = "server=localhost;database=devitem;user=root;password=123456";
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);  
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
 
            app.UseRouting();

            app.UseMiddleware<CusExpetionMiddleware>();

            app.UseCors("CorsPolicy");
            app.UseSwagger();

            app.UseApiLog();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
