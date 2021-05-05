using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.BAL.Mapper;
using StardekkMediorFullstackDeveloper.BAL.Services;
using StardekkMediorFullstackDeveloper.DAL;
using StardekkMediorFullstackDeveloper.DAL.Repositories.Repository;
using StardekkMediorFullstackDeveloper.Model.Repositories.Repository;
using StardekkMediorFullstackDeveloper.Repositories.Interface;
using StardekkMediorFullstackDeveloper.Repository.Interface;

namespace StardekkMediorFullstackDeveloper
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
            services.AddRazorPages();

            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            services.AddDbContext<StardekkDatabaseContext>(options => options.UseSqlite("Data Source=StardekkMediorFullstackDeveloper.db"));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAmenityRepository, AmenityRepository>().Reverse();
            services.AddScoped<IRoomRepository, RoomRepository>().Reverse();
            services.AddScoped<IRoomTypeRepository, RoomTypeRepository>().Reverse();
            services.AddScoped<IAmenityService, AmenityService>().Reverse();
            services.AddScoped<IRoomService, RoomService>().Reverse();
            services.AddScoped<IRoomTypeService, RoomTypeService>().Reverse();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
