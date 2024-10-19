using FoodConsluting.Repositories;
using FoodConsluting.Data;
using Microsoft.Extensions.Configuration;
namespace ReviewRepository
{
    public interface IReviewRepository : IBaseRepository<Review>
    {

    }

    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}