using MovieSStore.Models.DTO;

namespace MovieSStore.DataLayer.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(string id);

        Movie? GetMoviesById(string id);
    }
}
