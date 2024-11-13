using MovieSStore.Models.Models;

namespace MovieStoreB.DataLayer.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();
    }
}
