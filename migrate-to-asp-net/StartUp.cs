using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace migrate_to_asp_net
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from my API");
                });

                endpoints.MapGet("/start", async context =>
                {
                    await context.Response.WriteAsync("Start a new endpoint");
                });
            });
        }
    }
}
