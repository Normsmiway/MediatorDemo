using Microsoft.Extensions.DependencyInjection;

namespace MediatorDemo.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddWeatherService(this IServiceCollection services)
        {
            services.AddSingleton<IWeatherService, WeatherProvider>();
            return services;
        }
    }
}
