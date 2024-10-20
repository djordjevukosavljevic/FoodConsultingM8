using FoodConsluting.Data;
using AutoMapper;
using FoodConsluting.Repositories;
using ReviewRepository;

namespace FoodConsluting.Services
{
    public interface IReviewService : IBaseRepository<Review>
    {

    }

    public class ReviewService
    {
        private readonly IReviewRepository repository;
        
        private IMapper mapper;
        public ReviewService(IReviewRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
    }
}