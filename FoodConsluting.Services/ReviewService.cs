using AutoMapper;

namespace FoodConsluting.Services
{
    public interface IReviewService
    {

    }

    public class ReviewService
    {
        //private readonly IReviewRepository repository;
        
        private IMapper mapper;
        public ReviewService(/*IReviewRepository repository*/ IMapper mapper)
        {
            //this.repository = repository;
            this.mapper = mapper;
        }
    }
}