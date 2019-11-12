using System;
using FutCoach.Areas.Identity.Data;
using FutCoach.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FutCoach.Areas.Identity.IdentityHostingStartup))]
namespace FutCoach.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FutCoachContext1>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FutCoachContext1Connection")));

                services.AddDefaultIdentity<FutCoachUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FutCoachContext1>();
            });
        }
    }
}