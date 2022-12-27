using BoxOfficeDemo.Client.Configurations;
using BoxOfficeDemo.Shared.Models;
using System.Net.Http.Json;

namespace BoxOfficeDemo.Client.Services
{
    public class WatchListService : IWatchListService
    {
        private readonly HttpClient _client;
        public WatchListService(HttpClient Client) => _client = Client;

        public List<WatchListList> WatchListList { get; set; } = new();
        public async Task GetWatchList(string? id)
            => WatchListList = await _client.GetFromJsonAsync<List<WatchListList>>($"WatchList/GetWatchList/{id}");

        public async Task AddWatchList(SingleWatchList WatchList)
            => await _client.PostAsJsonAsync("WatchList/AddWatchList", WatchList);

        public async Task DeleteWatchList(decimal? id)
        {
            await _client.DeleteAsync($"WatchList/DeleteWatchList/{id}");
            Count--;
        }

        public int Count { get; set; } = 0;

        public event Action OnChange;

        public async Task Init()
        {
            if (!string.IsNullOrEmpty(LoggedUser.Id))
            {
                await GetWatchList(LoggedUser.Id);
                Count = WatchListList.Count;
                OnChange?.Invoke();
            }
        }

        public bool CheckMovieExistance(decimal id)
        {
            if (!WatchListList.Any(a => a.MovieID == id))
            {
                Count++;
                OnChange?.Invoke();
                return true;
            }
            else return false;
        }

    }
}
