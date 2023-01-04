using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services.Reviews
{
    public interface IReviewsService
    {
        List<ReviewsList> ReviewsList { get; set; }        
        Task GetReviews(decimal? id);
        Task<SingleReview> GetSingleReview(decimal? id);
        Task SaveReview(SingleReview review);
        Task DeleteReview(decimal? id);        
    }
}
