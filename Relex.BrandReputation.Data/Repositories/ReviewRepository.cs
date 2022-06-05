
using Relex.BrandReputation.Domain.DomainServices;

namespace Relex.BrandReputation.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public ReviewRepository(BrandReputationDbContext context)
        {
            Context = context;
        }

        private BrandReputationDbContext Context { get; }

        public async Task<IEnumerable<Review>> GetAll()
        {
            return await Context.Set<Review>().ToListAsync();
        }

        public async Task<Review> GetAsync(Guid reviewId)
        {
            return await Context.Set<Review>().FirstOrDefaultAsync(i => i.Id == reviewId);
        }

        public async Task AddAsync(Review review)
        {
            if(review == null)
            {
                throw new ArgumentNullException(nameof(review)); 
            }

            await Context.Set<Review>().AddAsync(review);
            await Context.SaveChangesAsync();
        }
    }
}
