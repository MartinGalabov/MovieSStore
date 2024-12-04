using Mapster;
using MovieSStore.Models.DTO;
using MovieSStore.Models.Request;

namespace MovieStoreB.MapsterConfig
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<AddMovieRequest, Movie>
                .NewConfig();
        }
    }
}