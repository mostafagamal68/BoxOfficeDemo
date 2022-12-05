//using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IMoviesLogic
    {
        List<MoviesList> GetMovies();
        SingleMovie GetMovie(decimal? id);
        void SaveMovie(SingleMovie singleMovie);
        void DeleteMovie(decimal? id);
    }
}
