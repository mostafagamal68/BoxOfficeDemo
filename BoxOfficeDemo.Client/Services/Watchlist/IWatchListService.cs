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
        event Action OnChange;
        Task Init();
        void Reset();

        bool CheckMovieExistance(decimal id);
    }
}
