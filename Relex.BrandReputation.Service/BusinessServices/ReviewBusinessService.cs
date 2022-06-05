
using AutoMapper;
using FluentValidation;
using Relex.BrandReputation.Domain.DomainServices;
using Relex.BrandReputation.Domain.Dtos;

namespace Relex.BrandReputation.Service.BusinessServices
{
    public class ReviewBusinessService : IReviewBusinessService
    {
        public ReviewBusinessService(IReviewRepository repository, IMapper mapper, IValidator<Review> reviewValidator)
        {
            Repository = repository;
            Mapper = mapper;
            ReviewValidator = reviewValidator;
        }

        private IReviewRepository Repository { get; }

        private IMapper Mapper { get; }
        private IValidator<Review> ReviewValidator { get; }

        public async Task<IEnumerable<ReviewMinifiedDto>> GetAllAsync()
        {
            return Mapper.Map<IEnumerable<ReviewMinifiedDto>>(await Repository.GetAll());
        }

        public async Task<ReviewDto> GetAsync(Guid reviewId)
        {
            return  Mapper.Map<ReviewDto>(await Repository.GetAsync(reviewId));
        }

        public async Task<ReviewDto> CreateAsync(ReviewForAddDto dto)
        {
            var review = Mapper.Map<Review>(dto);
            if(review == null)
            {
                //TODO : raise appropriate exception;
                throw new ArgumentException();
            }

            //TODO: Validate review
            ReviewValidator.ValidateAndThrow(review);


            await Repository.AddAsync(review);

            return Mapper.Map<ReviewDto>(review);
        }
    }
}
