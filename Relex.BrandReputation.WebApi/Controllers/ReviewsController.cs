using Microsoft.AspNetCore.Mvc;

using Relex.BrandReputation.Domain.DomainServices;
using Relex.BrandReputation.Domain.Dtos;

namespace Relex.BrandReputation.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        //FluentValidation.ValidationException 
    }

    [ApiController]
    [Route("api/reviews")]
    public class ReviewsController : ControllerBase
    {
        public ReviewsController(IReviewBusinessService businessService)
        {
            BusinessService = businessService;
        }

        private IReviewBusinessService BusinessService { get; }

        [HttpOptions]
        public IActionResult GetAuthorsOptions()
        {
            Response.Headers.Add("Allow", "GET,OPTIONS,POST");
            return Ok();
        }


        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetReviews()
        {
            return Ok(await BusinessService.GetAllAsync());
        }

        [HttpGet("{reviewId}",Name =nameof(GetReview))]
        public async Task<IActionResult> GetReview(Guid reviewId)
        {
            var data = await BusinessService.GetAsync(reviewId);
            if(data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(ReviewForAddDto review)
        {
            ReviewDto data = await BusinessService.CreateAsync(review);
            return CreatedAtRoute(nameof(GetReview), new { reviewId = data.Id }, data);
        }
    }
}
