using System;
using System.Data.SqlClient;
using Lab8.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Lab8.Areas.Identity.IdentityHostingStartup))]
namespace Lab8.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((context, services) => {
                var sbuilder = new SqlConnectionStringBuilder (
                    context.Configuration.GetConnectionString("DefaultConnection"));
                sbuilder.Password = context.Configuration["DBPassword"];

                services.AddDbContext<Lab8IdentityDbContext>(options =>
                    options.UseSqlServer(
                        sbuilder.ConnectionString));
                services.AddIdentity<Lab8Model,IdentityRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 8;
                    options.Password.RequiredUniqueChars = 1;
                }).AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()    
                    .AddEntityFrameworkStores<Lab8IdentityDbContext>();
            });
        }
    }
}