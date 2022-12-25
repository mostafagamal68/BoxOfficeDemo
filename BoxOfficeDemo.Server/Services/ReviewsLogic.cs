using BoxOfficeDemo.Server.Models;
using System.IO;
using System.Net.Http.Json;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BoxOfficeDemo.Shared.Configurations;

namespace BoxOfficeDemo.Client.Services
{
    public class ReviewsLogic : IReviewsLogic
    {
        private readonly BoxOfficeDBContext _context;
        private readonly IMapper _mapper;

        public ReviewsLogic(BoxOfficeDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ReviewsList> GetReviews(decimal? id)
        {
            return _mapper.Map<List<ReviewsList>>(_context.Reviews.Where(w => w.MovieID == id).OrderByDescending(o => o.ReviewDate).Include(i => i.User).ToList());
        }

        public SingleReview GetReview(decimal? id)
        {
            var Review = _context.Reviews.Find(id);

            if (Review == null)
                throw new Exception();

            return _mapper.Map<SingleReview>(Review);
        }

        public void SaveReview(SingleReview singleReview)
        {
            if (singleReview.IsNew == true)
            {
                Review review = _mapper.Map<Review>(singleReview);
                _context.Reviews.Add(review);
            }
            else if (singleReview.IsNew == false)
            {
                var review = _context.Reviews.Find(singleReview.ReviewID);
                if (review != null)
                {
                    review.Rate = singleReview.Rate;
                    review.Feedback = singleReview.Feedback;
                    review.ReviewDate = DateTime.Now;
                }
            }
            _context.SaveChanges();
        }
        public void DeleteReview(decimal? id)
        {
            var review = _context.Reviews.Find(id);
            if (review != null)
                _context.Reviews.Remove(review);
            _context.SaveChanges();
        }

    }
}

