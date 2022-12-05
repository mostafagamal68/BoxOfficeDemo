using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoxOfficeDemo.Client.Services;
using BoxOfficeDemo.Shared.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Server.Models;

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

        //// PUT: api/Movies/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMovie(int id, Movie movie)
        //{
        //    if (id != movie.MovieID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(movie).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MovieExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Movies
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        //{
        //    _context.Movies.Add(movie);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetMovie", new { id = movie.MovieID }, movie);
        //}

        //// DELETE: api/Movies/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMovie(int id)
        //{
        //    var movie = await _context.Movies.FindAsync(id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Movies.Remove(movie);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool MovieExists(int id)
        //{
        //    return _context.Movies.Any(e => e.MovieID == id);
        //}
    }
}
