using MovieSStore.Models.Responses;

namespace MovieSStore.BizLayer.Interfaces
{
    public interface IBlMovieService
    {
        List<FullMovieDetails> GetAllMovieDetails();
    }
}
