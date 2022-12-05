using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IReviewsService
    {
        List<ReviewsList> ReviewsList { get; set; }
        //SingleReview Review { get; set; }
        Task GetReviews(decimal? id);
        Task<SingleReview> GetSingleReview(decimal? id);
        Task SaveReview(SingleReview review);
        Task DeleteReview(decimal? id);

        //Task<Reviews> SaveReview(Reviews data, bool IsNew);
    }
}
