//using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Shared.Models;

namespace BoxOfficeDemo.Client.Services
{
    public interface IReviewsLogic
    {
        List<ReviewsList> GetReviews(decimal? id);
        SingleReview GetReview(decimal? id);
        void SaveReview(SingleReview singleReview);
        void DeleteReview(decimal? id);

    }
}
