using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace migrate_to_asp_net
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("MiddleWare with USE 1\n");
                await next();
                await context.Response.WriteAsync("MiddleWare with USE 2\n");
            });
            app.Map("/yas", CustomCode);

            app.UseMiddleware<CustomMiddleware>();

            app.Run(async context => {
                await context.Response.WriteAsync("MiddleWare with RUN\n");
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("MiddleWare from custom yas\n");
            });
        }
    }
}
