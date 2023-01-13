using BoxOfficeDemo.Client.Services;
using BoxOfficeDemo.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoxOfficeDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesLogic moviesLogic;
        public MoviesController(IMoviesLogic moviesLogic)
        {
            this.moviesLogic = moviesLogic;
        }

        // GET: api/Movies
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(moviesLogic.GetMovies());
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public IActionResult GetMovie(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return Ok(moviesLogic.GetMovie(id));
        }

        [HttpPost("SaveMovie")]
        public IActionResult SaveMovie(SingleMovie movie)
        {
            if (movie == null)
            {
                return NotFound();
            }
            moviesLogic.SaveMovie(movie);
            return Ok();
        }

        [HttpDelete("DeleteMovie/{id}")]
        public IActionResult DeleteMovie(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            moviesLogic.DeleteMovie(id);
            return Ok();
        }
    }
}
