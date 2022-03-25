using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service.DataLayer.Models;
using Service.DataLayer.ModelsNew;
using Service.DataLayer.Connection;
using Service.DataLayer.Connection.Configuration;
using Service.DataLayer.Repository;

namespace GreenFactory
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _config = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddEntityFrameworkSqlServer();

            string DatabaseConn = DBAppConfigHelper.ConnDb(
                 _config.GetConnectionString("ServiceDBConnection"),
                 _config.GetConnectionString("DBUsername"),
                 _config.GetConnectionString("DBPassword")
                 );

            services.AddDbContext<PageDBContext>((serviceProvider, optionsBuilder) =>
            {
                //optionsBuilder.UseSqlServer(_config.GetConnectionString("ServiceDBConnection"));
                optionsBuilder.UseSqlServer(DatabaseConn);
                optionsBuilder.UseInternalServiceProvider(serviceProvider);
            });

            services.AddDbContextPool<AppDbContext>(
             options => options.UseSqlServer(DatabaseConn));
            //options => options.UseSqlServer(_config.GetConnectionString("ServiceDBConnection")));

            //services.AddDbContextPool<EmployeeContext>(
            //options => options.UseSqlServer(_config.GetConnectionString("ServiceDBConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>().
                AddEntityFrameworkStores<AppDbContext>();

            services.AddMvc(config => {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            
            services.AddTransient<ISendEmail, SendEmail>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseExceptionHandler("/Home/Error");
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
            });
        }
    }
}
