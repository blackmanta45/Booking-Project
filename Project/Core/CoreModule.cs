using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class CoreModule
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}