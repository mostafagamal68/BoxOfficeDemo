using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IMoviesService
    {
        List<MoviesList> MoviesList { get; set; }
        //SingleMovie Movie { get; set; }
        Task GetMovies();
        Task<SingleMovie> GetMovie(decimal? id);
        Task SaveMovie(SingleMovie movie);
        Task DeleteMovie(decimal? id);

    }
}
