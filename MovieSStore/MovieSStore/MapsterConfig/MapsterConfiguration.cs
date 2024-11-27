using Mapster;

namespace MovieSStore.MapsterConfig
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<AddMovieReques, Movie>
                .NewConfig();
        }
    }
}
