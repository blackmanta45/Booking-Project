using System;
using System.IO;
using Core.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            var appSettings = GetAppSettings();
            optionsBuilder.UseSqlServer(appSettings.DbConnectionString,
                b => b.MigrationsAssembly(appSettings.MigrationAssembly));

            return new AppDbContext(optionsBuilder.Options);
        }

        private static AppSettings GetAppSettings()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Presentation"))
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{environment}.json", true)
                .AddEnvironmentVariables()
                .Build();

            return config.GetSection(nameof(AppSettings)).Get<AppSettings>();
        }
    }
}