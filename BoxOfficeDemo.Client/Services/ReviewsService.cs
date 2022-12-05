using BoxOfficeDemo.Shared.Models;
using System.Net.Http.Json;

namespace BoxOfficeDemo.Client.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly HttpClient _client;
        public ReviewsService(HttpClient Client) => _client = Client;

        public List<ReviewsList> ReviewsList { get; set; } = new();
        //public SingleReview Review { get; set; } = new();
        public async Task GetReviews(decimal? id)
            => ReviewsList = await _client.GetFromJsonAsync<List<ReviewsList>>($"Reviews/GetReviews/{id}");

        public async Task<SingleReview> GetSingleReview(decimal? id)
            => await _client.GetFromJsonAsync<SingleReview>($"Reviews/GetReview/{id}");

        public async Task SaveReview(SingleReview review)
            => await _client.PostAsJsonAsync("Reviews/SaveReview",review);

        public async Task DeleteReview(decimal? id)
            => await _client.DeleteAsync($"Reviews/DeleteReview/{id}");
        //(Reviews)ReviewsList.Where(w => w.ReviewID == id).FirstOrDefault().Clone();

    }
}
