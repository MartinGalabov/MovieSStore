using Microsoft.Extensions.DependencyInjection;
using MovieSStore.BizLayer.Interfaces;
using MovieSStore.BizLayer.Services;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.DataLayer.Repositories.MongoRepositories;

namespace MovieSStore.BizLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IMovieService, MovieService>();
            services.AddSingleton<IActorRepository, ActorRepository>();

            return services;
        }
    }
}