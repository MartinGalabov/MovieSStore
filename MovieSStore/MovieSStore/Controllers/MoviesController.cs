using Microsoft.AspNetCore.Mvc;
using MovieSStore.BizLayer.Interfaces;
using MovieSStore.Models.DTO;

namespace MovieSStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Movie> GetAll()
        {
            return _movieService.GetMovies();
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            if (id <= 0) return BadRequest();

            var result =
                _movieService.GetMoviesById(id);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpPost("AddMovie")]
        public void AddMovie([FromBody] Movie movie)
        {
            _movieService.AddMovie(movie);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest($"Wrong id:{id}");

            _movieService.DeleteMovie(id);

            return Ok();
        }
    }
}