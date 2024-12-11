using Microsoft.Extensions.DependencyInjection;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.DataLayer.Repositories;

namespace MovieSStore.BizLayer
{
    public static class DependInjection
    {
        public static IServiceCollection

            AddDataDependencies(this IServiceCollection services)
        {

            services.AddSingleton<IMovieRepository, MovieStaticRepository>();
            services.AddSingleton<IActorRepository, ActorStaticRepository>();

            return services;
        }

    }
}
