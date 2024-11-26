using Microsoft.Extensions.DependencyInjection;
using MovieSStore.BizLayer.Interfaces;
using MovieSStore.BizLayer.Services;

namespace MovieSStore.BizLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IMovieService, MovieService>();

            return services;
        }
    }
}