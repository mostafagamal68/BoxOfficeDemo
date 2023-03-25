using BoxOfficeDemo.Shared.DTO;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services.Movies
{
    public interface IMoviesService
    {
        List<MoviesList> MoviesList { get; set; }        
        Task GetMovies();
        Task<MoviesFilterAndPagination> GetMoviesList(int page, string name = "");
        Task<SingleMovie> GetMovie(decimal? id);
        Task SaveMovie(SingleMovie movie);
        Task DeleteMovie(decimal? id);
    }
}
