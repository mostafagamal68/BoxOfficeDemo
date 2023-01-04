using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services.Movies
{
    public class MoviesService : IMoviesService
    {
        private readonly HttpClient _client;
        //private readonly JsonSerializerOptions _options;
        public MoviesService(HttpClient Client) => _client = Client;
        //this._client.BaseAddress = new Uri();
        //_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public List<MoviesList> MoviesList { get; set; } = new();
        
        public async Task GetMovies()
            => MoviesList = await _client.GetFromJsonAsync<List<MoviesList>>("Movies");

        public async Task<SingleMovie> GetMovie(decimal? id)
            => await _client.GetFromJsonAsync<SingleMovie>($"Movies/{id}");

        public async Task SaveMovie(SingleMovie movie)
            => await _client.PostAsJsonAsync("Movies/SaveMovie", movie);
        public async Task DeleteMovie(decimal? id)
        {
            var respone = await _client.DeleteAsync($"Movies/DeleteMovie/{id}");
            if (respone.IsSuccessStatusCode)
                MoviesList.Remove(MoviesList.Where(c => c.MovieID == id).FirstOrDefault());
        }
    }
}

