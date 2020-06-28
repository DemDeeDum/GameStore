using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.BLL.Dependencies;
using GameStore.WEB.Service;
using GameStore.WEB.Dependencies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;

namespace GameStore.WEB
{
    public partial class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());

            services.AddRazorPages()    
                .AddRazorRuntimeCompilation();

            new WEBDependencies(services);
            new BLLDependencies(services, 
                new Dictionary<string, string>()
                {
                    {"GameStoreContext", Config.ConnectionString }
                });

            services.ConfigureApplicationCookie(opts =>
            {
                opts.Cookie.Name = "XStoreAuth";
                opts.Cookie.HttpOnly = true;
                opts.LoginPath = "/Account/Login";
                opts.AccessDeniedPath = "/Account/AccessDenied";
                opts.SlidingExpiration = true;
            });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            services.AddControllersWithViews(x=>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            //после UseRouting и до EndPoints всегад
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapAreaControllerRoute("admin", "Admin", "{controller=Public}/{action=Main}/{id?}");
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Public}/{action=Main}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Public}/{action=Main}/{id?}");
            });
        }
    }
}
