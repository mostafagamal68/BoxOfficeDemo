using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoxOfficeDemo.Client.Services;
using BoxOfficeDemo.Shared.Models;
using BoxOfficeDemo.Server.Models;

namespace BoxOfficeDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewsLogic reviewsLogic;
        public ReviewsController(IReviewsLogic reviewsLogic)
        {
            this.reviewsLogic = reviewsLogic;
        }

        [HttpGet("GetReviews/{id}")]
        public IActionResult GetReviews(decimal? id)
        {
            return Ok(reviewsLogic.GetReviews(id));
        }

        [HttpGet("GetReview/{id}")]
        public IActionResult GetReview(decimal? id)
        {
            if (id == null)
                return NotFound();
            return Ok(reviewsLogic.GetReview(id));
        }

        [HttpPost("SaveReview")]
        public IActionResult SaveReview(SingleReview singleReview)
        {
            if (singleReview == null)
                return NotFound();
            reviewsLogic.SaveReview(singleReview);
            return Ok();
        }

        [HttpDelete("DeleteReview/{id}")]
        //[Route("GetReview")]
        public IActionResult DeleteReview(decimal? id)
        {
            if (id == null)
                return NotFound();
            reviewsLogic.DeleteReview(id);
            return Ok();
        }
    }
}
