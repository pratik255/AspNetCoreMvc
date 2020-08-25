using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TheStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 1st middleware");
            //    await next();
            //    await context.Response.WriteAsync("Bye from 1st middleware");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 2nd middleware");
            //    await next();
            //    await context.Response.WriteAsync("Bye from 2nd middleware");
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        if(env.IsDevelopment())
            //        {
            //            await context.Response.WriteAsync("I'm from Dev");
            //        }
            //        else if (env.IsStaging())
            //        {
            //            await context.Response.WriteAsync("I'm from Stage");
            //        }
            //        if (env.IsProduction())
            //        {
            //            await context.Response.WriteAsync("I'm from Prod");
            //        }
            //        await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/pratik", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Pratik!");
            //    });
            //});
        }
    }
}
