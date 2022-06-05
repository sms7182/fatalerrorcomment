using Relex.BrandReputation.Core.Bases;

namespace Relex.BrandReputation.Domain.Dtos
{
    public class ReviewDto : IDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public string Content { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        public bool HasExpired { get; set; }

        public bool HasStarted { get; set; }

        public string CreatedTimeElapsed { get; set; }
    }
}
