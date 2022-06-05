using Relex.BrandReputation.Core.Bases;

namespace Relex.BrandReputation.Domain.Dtos
{

    public class  ReviewMinifiedDto : IDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TruncatedContent { get; set; }

        public bool HasExpired { get; set; }

        public bool HasStarted { get; set; }

        public string CreatedTimeElapsed  { get; set; }

    }
}
