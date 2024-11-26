using MovieSStore.Models.DTO;

namespace MovieSStore.BizLayer.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(int id);

        Movie? GetMoviesById(int id);
    }
}
