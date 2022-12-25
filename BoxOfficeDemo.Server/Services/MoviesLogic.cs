using BoxOfficeDemo.Server.Models;
using System.IO;
using System.Net.Http.Json;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Shared.Models;
using AutoMapper;

namespace BoxOfficeDemo.Client.Services
{
    public class MoviesLogic : IMoviesLogic
    {
        private readonly BoxOfficeDBContext _context;
        private readonly IMapper _mapper;

        public MoviesLogic(BoxOfficeDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesList> GetMovies()
        {
            return _mapper.Map<List<MoviesList>>(_context.Movies.ToList());
        }

        public SingleMovie GetMovie(decimal? id)
        {
            var Movie = _context.Movies.Find(id);

            if (Movie == null)
                throw new Exception();

            return _mapper.Map<SingleMovie>(Movie);
        }

        public void SaveMovie(SingleMovie singleMovie)
        {
            if (singleMovie.IsNew == true)
            {
                Movie movie = _mapper.Map<Movie>(singleMovie);
                _context.Movies.Add(movie);
            }
            else if (singleMovie.IsNew == false)
            {
                var movie = _context.Movies.Find(singleMovie.MovieID);
                if (movie != null)
                    _ = _mapper.Map<Movie>(singleMovie);
            }
            
            _context.SaveChanges();
        }

        public void DeleteMovie(decimal? id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}

