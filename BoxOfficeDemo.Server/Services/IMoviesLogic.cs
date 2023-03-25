//using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Shared.DTO;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IMoviesLogic
    {
        List<MoviesList> GetMovies();
        MoviesFilterAndPagination GetMoviesList(int page, string name);
        SingleMovie GetMovie(decimal? id);
        void SaveMovie(SingleMovie singleMovie);
        void DeleteMovie(decimal? id);
    }
}
