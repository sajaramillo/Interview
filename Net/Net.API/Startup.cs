﻿using Net.Data;
using Microsoft.EntityFrameworkCore;
using Net.Data.Repositories;
using Net.Data.Entities;

namespace Net.API
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
           
            services.AddDbContext<ApplicationDbContext>(
            options =>
             options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICustomerRepository,CustomerRepository>();
            services.AddScoped<IRepository<Customer>,CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddControllers();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}