using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IWatchListService
    {
        List<WatchListList> WatchListList { get; set; }
        Task GetWatchList(string? id);
        Task AddWatchList(SingleWatchList review);
        Task DeleteWatchList(decimal? id);
        int Count { get; set; }

        event Action OnChange;

        bool AddMovieToWatchList(string name);
    }
}
