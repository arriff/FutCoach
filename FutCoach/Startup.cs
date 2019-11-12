
using FutCoach.Areas.Identity.Data;
using FutCoach.Models;
using FutCoach.Repositories;
using FutData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FutCoach
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<INationRepository, NationRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ILeagueRepository, LeagueRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();

            services.AddDefaultIdentity<FutCoachUser>()
                .AddEntityFrameworkStores<IdentityContext>();

            services.AddRazorPages();

            services.AddDbContext<IdentityContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("IdentityConnection"),
        sqlOptions => sqlOptions.MigrationsAssembly("FutCoach")));

            services.AddDbContext<FutCoachDbContext>(options =>
                       options.UseSqlServer(configuration.GetConnectionString("FutCoachConnection"),
                    sqlOptions => sqlOptions.MigrationsAssembly("FutCoach")));
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
