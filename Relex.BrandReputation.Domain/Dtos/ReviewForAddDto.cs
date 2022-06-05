using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Relex.BrandReputation.Core.Bases;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Relex.BrandReputation.Domain.Dtos
{
    public class ReviewForAddDto : IDto
    {
        [Required]
        [MaxLength(120)]
        public string Name { get; init; }

        [Required]
        public string Content { get; init; }



        public DateTimeOffset? StartDate { get; set; }



        public DateTimeOffset? EndDate { get; set; }
    }

}



