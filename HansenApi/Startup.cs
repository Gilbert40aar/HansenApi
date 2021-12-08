using HansenApi.Database;
using HansenApi.Interfaces;
using HansenApi.Models;
using HansenApi.Reporsitories;
using HansenApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HansenApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string _policyName = "CorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .WithMethods("GET", "PUT", "POST", "DELETE")
                           .AllowAnyMethod();
                });
            });
            services.AddSignalR();
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminReporsitory, AdminReporsitory>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactReporsitory, ContactReporsitory>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IEducationReporsitory, EducationReporsitory>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IGenreReporsitory, GenreReporsitory>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<ILocationReporsitory, LocationReporsitory>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IProfileReporsitory, ProfileReporsitory>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectReporsitory, ProjectReporsitory>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<ISettingReporsitory, SettingReporsitory>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ISkillsReporsitory, SkillsReporsitory>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IStatusReporsitory, StatusReporsitory>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddScoped<IWorkReporsitory, WorkReporsitory>();
            services.AddScoped<IMessagesService, MessagesService>();
            services.AddScoped<IMessagesReporsitory, MessageReporsitory>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HansenApi", Version = "v1" });
            });

            //Singleton of JWTSettings -> transfer data(the secretkey) from appsettings to our new model
            var jwtSection = Configuration.GetSection("JWTSettings"); 
            services.Configure<JWTSettingsModel>(jwtSection);

            var appSettings = jwtSection.Get<JWTSettingsModel>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true; // i en anden film er den false
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HansenApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(_policyName);
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapHub<BroadcastHub>("/notify");
                });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
