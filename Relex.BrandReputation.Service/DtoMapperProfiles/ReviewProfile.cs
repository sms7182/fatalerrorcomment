using AutoMapper;

using Relex.BrandReputation.Domain.Dtos;
using Relex.BrandReputation.Service.DtoMapperProfiles.MappingActions;

namespace Relex.BrandReputation.Service.DtoMapperProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewMinifiedDto>()
                .AfterMap<ReviewMinifiedMappingAction>();

            CreateMap<Review, ReviewDto>()
               .AfterMap<ReviewMappingAction>();
            
            CreateMap<ReviewForAddDto, Review>();
        }
    }
}
