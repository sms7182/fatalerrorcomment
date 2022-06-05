using AutoMapper;

using Relex.BrandReputation.Domain.Dtos;

using TimeLocalization.Extensions;

namespace Relex.BrandReputation.Service.DtoMapperProfiles.MappingActions
{
    public class ReviewMappingAction : IMappingAction<Review, ReviewDto>
    {
        public ReviewMappingAction()
        {

        }

        public void Process(Review source, ReviewDto destination, ResolutionContext context)
        {
            destination.HasExpired = source.EndDate.HasValue && source.EndDate.Value.UtcDateTime < DateTimeOffset.UtcNow;
            destination.HasStarted = !destination.HasExpired && source.StartDate.HasValue && source.StartDate.Value.UtcDateTime >= DateTimeOffset.UtcNow;
            destination.CreatedTimeElapsed = source.CreatedDate.UtcDateTime.AsTimeAgo();

        }
    }
}
