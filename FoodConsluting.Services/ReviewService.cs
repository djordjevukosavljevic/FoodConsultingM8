using FoodConsluting.Data;
using AutoMapper;
using FoodConsluting.Repositories;

namespace FoodConsluting.Services
{
    public interface IReviewServic
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