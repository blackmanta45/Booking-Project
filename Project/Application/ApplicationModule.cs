using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            //services.AddScoped<IFeedbackService, FeedbackService>();

            return services;
        }
    }
}