using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateTask.DataAccess;

namespace TemplateTask
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=TemplateEterna;Trusted_Connection=true");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.HasValue && context.Request.Path.Value.Contains("/about-us"))
                {
                    context.Response.Redirect("/home/about");
                }
                else
                {
                    await next();
                }
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.HasValue && context.Request.Path.Value.Contains("/contact-us"))
                {
                    context.Response.Redirect("/home/contact");
                }
                else
                {
                    await next();
                }
            });


        }
    }
}
