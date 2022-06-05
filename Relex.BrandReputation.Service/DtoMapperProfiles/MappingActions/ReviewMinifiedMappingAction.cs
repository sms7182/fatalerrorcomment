using AutoMapper;
using Relex.BrandReputation.Domain.DomainServices;
using Relex.BrandReputation.Domain.Dtos;
using Relex.BrandReputation.Service.Resolvers;

using TimeLocalization.Extensions;

namespace Relex.BrandReputation.Service.DtoMapperProfiles.MappingActions
{
    public class ReviewMinifiedMappingAction : IMappingAction<Review, ReviewMinifiedDto>
    {
        public ReviewMinifiedMappingAction(IContentTruncateResolver contentTruncateResolver)
        {
            ContentTruncateResolver = contentTruncateResolver;
        }

        private IContentTruncateResolver ContentTruncateResolver { get; }

        public void Process(Review source, ReviewMinifiedDto destination, ResolutionContext context)
        {
            destination.TruncatedContent = ContentTruncateResolver.Truncate(source.Content);
            destination.HasExpired = source.EndDate.HasValue && source.EndDate.Value.UtcDateTime < DateTimeOffset.UtcNow;
            destination.HasStarted = !destination.HasExpired && source.StartDate.HasValue && source.StartDate.Value.UtcDateTime >= DateTimeOffset.UtcNow;
            destination.CreatedTimeElapsed = source.CreatedDate.UtcDateTime.AsTimeAgo();

        }
    }
}
