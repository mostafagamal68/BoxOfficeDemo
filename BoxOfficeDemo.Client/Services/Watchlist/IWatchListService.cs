using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services.Watchlist
{
    public interface IWatchListService
    {
        List<WatchListList> WatchListList { get; set; }
        Task GetWatchList(string? id);
        Task AddWatchList(SingleWatchList review);
        Task DeleteWatchList(decimal? id);
        int Count { get; set; }
        Task Init();
        event Action OnChange;

        bool CheckMovieExistance(decimal id);
    }
}
