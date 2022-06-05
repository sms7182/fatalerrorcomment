using Relex.BrandReputation.Core.Bases;

namespace Relex.BrandReputation.Domain.Entities
{
    public class Review : IEntity
    {
        public Review(string name, string content)
        {
            Name = name;
            Content = content;
        }

        [Key]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(120)]
        public string Name { get; init; }

        [Required]
        public string Content { get; init; }

        public DateTimeOffset CreatedDate { get; init; } = DateTimeOffset.Now;

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }
    }


}