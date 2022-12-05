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
            var List = _context.Movies.Select(s=> new MoviesList
            {
                MovieID= s.MovieID,
                Genere= s.Genere,
                Length= s.Length,
                Image= s.Image,
                MovieName= s.MovieName,
                ParentalGuide= s.ParentalGuide,
                Rate= s.Rate,
                ReleasedDate= s.ReleasedDate
            }).ToList();
            //List<MoviesList> MoviesList = _mapper.Map<List<MoviesList>>(List);
            
            return List;
        }

        public SingleMovie GetMovie(decimal? id)
        {
            var Movie = _context.Movies.Find(id);

            if (Movie == null)
            {
                throw new Exception();
            }

            SingleMovie SingleMovie = _mapper.Map<SingleMovie>(Movie);

            return SingleMovie;
        }

        public void SaveMovie(SingleMovie singleMovie)
        {
            if (singleMovie.IsNew == true)
            {
                Movie movie = _mapper.Map<Movie>(singleMovie);
                //Movie movie = new()
                //{
                //    MovieName = singleMovie.MovieName,
                //    Image = singleMovie.Image,
                //    ParentalGuide = singleMovie.ParentalGuide,
                //    Genere = singleMovie.Genere,
                //    Length = singleMovie.Length,
                //    ReleasedDate = singleMovie.ReleasedDate,
                //    Description = singleMovie.Description,
                //    Director= singleMovie.Director,
                //    Rate = singleMovie.Rate,
                //    Stars= singleMovie.Stars,
                //    Writer= singleMovie.Writer
                //};
                _context.Movies.Add(movie);
            }
            else if (singleMovie.IsNew == false)
            {
                Movie movie = _context.Movies.Find(singleMovie.MovieID);
                if (movie != null)
                {
                    _ = _mapper.Map<Movie>(singleMovie);
                    //movie.MovieName = singleMovie.MovieName;
                    //movie.Image = singleMovie.Image;
                    //movie.Description = singleMovie.Description;
                    //movie.ParentalGuide = singleMovie.ParentalGuide;
                    //movie.ReleasedDate = (DateTime)singleMovie.ReleasedDate;
                    //movie.Genere = singleMovie.Genere;
                    //movie.Length = singleMovie.Length;

                }
            }
            
            _context.SaveChanges();
        }

        public void DeleteMovie(decimal? id)
        {
            Movie movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}

