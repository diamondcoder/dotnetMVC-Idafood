using System;
using Idafood.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Idafood
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurantData, InMemorRestaurantData>();// Use it one and thrwo it away and creat another instance for the next application that needs it
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            IGreeter greeter)
        {
           if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /* app.UseWelcomePage(new WelcomePageOptions
             {
                 Path = "/wp"
             }
                 ); */
            app.UseFileServer();

            
            //app.UseDefaultFiles();
             
           
            app.UseStaticFiles();   //Routes to static files

            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessageOfTheDay();
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"{ greeting} : {env.EnvironmentName}");
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // /Hpme/Index/4
            routeBuilder.MapRoute("Default",
                "{controller=Home}/{action=Index}/{id?}");

            //{controller} second part of the namer of the controller
            //{action} this is the methodit should call to render
        }
    }
}
