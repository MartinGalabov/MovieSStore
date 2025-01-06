using MovieSStore.Models.Configurations;

namespace MovieSStore.ServiceExtensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddConfigurations(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<MongoDbConfiguration>(config.GetSection(nameof(MongoDbConfiguration)));

            return services;
        }
    }
}