using System;
using Microsoft.Extensions.Hosting;


namespace migrate_to_asp_net
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDeafaults(webHost =>
            {
                webHost.UseStartup<StartUp>();
            });
        }
    }
}
