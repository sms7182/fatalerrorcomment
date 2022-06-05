using Relex.BrandReputation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relex.BrandReputation.Domain.DomainServices
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Review>> GetAll();
        
        Task<Review> GetAsync(Guid id);

        Task AddAsync(Review review);

        //IEnumerable<Review> GetAuthors(ReviewsResourceParameters authorsResourceParameters);

        //Review GetAuthor(Guid authorId);

        //IEnumerable<Review> GetReviews(IEnumerable<Guid> authorIds);

        //void Add(Review author);

        //void Delete(Review author);

        //void Update(Review author);

        //bool Exists(Guid authorId);

        //bool Save();
    }
}
