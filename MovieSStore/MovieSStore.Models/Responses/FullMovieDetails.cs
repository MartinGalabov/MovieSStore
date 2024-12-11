using MovieSStore.Models.DTO;

namespace MovieSStore.Models.Responses
{
    public class FullMovieDetails
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<Actor> Actors { get; set; }
    }
}