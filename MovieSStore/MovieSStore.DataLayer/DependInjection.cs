using Microsoft.Extensions.DependencyInjection;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.DataLayer.Repositories;
using MovieSStore.DataLayer.Repositories.MongoRepositories;

namespace MovieSStore.BizLayer
{
    public static class DependInjection
    {
        public static IServiceCollection

            AddDataDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IMovieRepository, MoviesRepository>();
            services.AddSingleton<IActorRepository, ActorStaticRepository>();

            return services;
        }
    }
}
