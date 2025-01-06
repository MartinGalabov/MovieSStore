using MovieSStore.Models.DTO;

namespace MovieSStore.BizLayer.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(string id);

        Movie? GetMoviesById(string id);
    }
}
