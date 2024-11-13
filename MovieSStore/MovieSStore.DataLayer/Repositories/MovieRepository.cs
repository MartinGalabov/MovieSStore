using MovieStoreB.DataLayer.DataBase;
using MovieStoreB.DataLayer.Interfaces;
using MovieStoreB.Models.Models;

namespace MovieStoreB.DataLayer.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
    }
}
