using MovieSStore.DataLayer.DataBase;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.Models.DTO;

namespace MovieSStore.DataLayer.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
    }
}
