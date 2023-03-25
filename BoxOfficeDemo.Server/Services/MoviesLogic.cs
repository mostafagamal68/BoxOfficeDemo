using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Shared.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using BoxOfficeDemo.Shared.DTO;

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

            return Movie == null ? throw new Exception() : _mapper.Map<SingleMovie>(Movie);
        }

        public void SaveMovie(SingleMovie singleMovie)
        {
            if (singleMovie.IsNew == true)
                _context.Movies.Add(_mapper.Map<Movie>(singleMovie));

            else if (singleMovie.IsNew == false)
            {
                Movie? movie = _context.Movies.Find(singleMovie.MovieID);
                if (movie != null)
                    _mapper.Map(singleMovie, movie);
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

        public MoviesFilterAndPagination GetMoviesList(int page, string name)
        {
            var list = new MoviesFilterAndPagination();
            var query = _context.Movies.OrderByDescending(c => c.ReleasedDate).AsQueryable();
            if (!string.IsNullOrEmpty(name))
                query = query.Where(x => x.MovieName.Contains(name));

            list.Count = Convert.ToInt32(Math.Round(Convert.ToDecimal(query.Count()) / 10, MidpointRounding.ToPositiveInfinity));
            list.Items = _mapper.Map<List<MoviesList>>(query.Skip(page * 10).Take(10));
            list.PageIndex = page;
            return list;
        }
    }
}

