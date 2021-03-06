﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab8.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Health.Repositories;
using Injury.Repositories;
using WorkOut.Repositories;
using Rehab.Repositories;
using Coach.Repositories;
using Repositories.Group;
using Repositories.InjuryLog;
using System.Data.SqlClient;

namespace Lab8
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var builder = new SqlConnectionStringBuilder (
                Configuration.GetConnectionString("DefaultConnection"));
            builder.Password = Configuration["DBPassword"];

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    builder.ConnectionString));
            //services.AddDefaultIdentity<Lab8Model>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.Configure<Lab8Settings>(Configuration);
            services.AddTransient<IHealthRepository, HealthCachingDBRepository>();
            services.AddTransient<IRehabRepository, RehabCachingDBRepository>();
            services.AddTransient<IWorkOutRepository, WorkOutCachingDBRepository>();
            services.AddTransient<IInjuryRepository, InjuryCachingDBRepository>();
            services.AddTransient<IInjuryLogRepository, InjuryLogCachingDBRepository>();
            services.AddTransient<ICoachRepository, CoachCachingDBRepository>();
            services.AddTransient<IGroupRepository, GroupCachingDBRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
