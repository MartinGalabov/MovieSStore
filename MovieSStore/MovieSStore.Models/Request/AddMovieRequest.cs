namespace MovieSStore.Models.Request
{
    public class AddMovieRequest
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> ActorIds { get; set; }
    }
}
