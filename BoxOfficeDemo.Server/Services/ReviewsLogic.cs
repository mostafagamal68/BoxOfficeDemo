using BoxOfficeDemo.Server.Models;
using BoxOfficeDemo.Server.Data;
using BoxOfficeDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

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

            return Review == null ? throw new Exception() : _mapper.Map<SingleReview>(Review);
        }

        public void SaveReview(SingleReview singleReview)
        {
            if (singleReview.IsNew == true)
                _context.Reviews.Add(_mapper.Map<Review>(singleReview));
            
            else if (singleReview.IsNew == false)
            {
                Review? review = _context.Reviews.Find(singleReview.ReviewID);
                if (review != null)
                    _mapper.Map(singleReview, review);
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

