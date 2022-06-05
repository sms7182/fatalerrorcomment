

using Relex.BrandReputation.Domain.Dtos;

namespace Relex.BrandReputation.Domain.DomainServices
{
    public interface IReviewBusinessService
    {
        Task<IEnumerable<ReviewMinifiedDto>> GetAllAsync();
        
        Task<ReviewDto> GetAsync(Guid reviewId);

        Task<ReviewDto> CreateAsync(ReviewForAddDto review);
    }
}
