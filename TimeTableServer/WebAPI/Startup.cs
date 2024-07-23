using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using WebApi.Mapping;
using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Writers;
using NUnit.Framework;
using System.Data.Entity;
using System.Text.Json;

namespace project1
{
    public class Startup
    {
    public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<GradeService, GradeService>();
            services.AddScoped<HouerService, HouerService>();
            services.AddScoped<DayService, DayService>();
            services.AddScoped<ResultService, ResultService>();
            services.AddScoped<SubjectService, SubjectService>();
            services.AddScoped<TeacherService, TeacherService>();
            services.AddScoped<LessonService, LessonService>();
            services.AddScoped<ConstrainsService, ConstrainsService>();
            services.AddScoped<SubjectForCycleService, SubjectForCycleService>();

            services.AddDbContext<ScechualDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ProjectSofiDbConnectionString")));
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddControllers();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


     
            services.AddMvc();

           
            var mapper = AutoMappingConfig.RegisterMappings();
            services.AddSingleton(mapper);
            services.AddAutoMapper(typeof(Startup));
           
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", t =>
                t.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

        }
        
       
          
       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowAll");

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "my api v1");
            });

        }
    }
}