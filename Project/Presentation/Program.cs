using System.Threading.Tasks;
using Infrastructure.Data;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Presentation
{
    public class Program
    {
        public static async Task Main(string[] args)
        { 
            var webHost = CreateHostBuilder(args).Build();

            using (var serviceScope = webHost.Services.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (context is not null)
                {
                    await context.Database.MigrateAsync();
                    await context.SeedRemainingData();
                }
            }

            await webHost.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}