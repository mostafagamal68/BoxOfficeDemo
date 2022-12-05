//using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IWatchListLogic
    {
        List<WatchListList> GetWatchList(string? id);
        void AddWatchList(SingleWatchList singleWatchList);
        void DeleteWatchList(decimal? id);

    }
}
