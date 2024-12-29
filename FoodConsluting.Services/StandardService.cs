using AutoMapper;
using FoodConsluting.Data;
using FoodConsluting.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoodConsluting.Services
{
    public interface IStandardService
    {

        public List<Standard> GetAll();
    }

    public class StandardService : IStandardService
    {
        private readonly IStandardRepository repository;

        private readonly IMapper mapper;


        public StandardService(IStandardRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<Standard> GetAll()
        {
            var resulltFromDb = repository.GetAll();
            var resultModels = mapper.Map<List<Standard>>(resulltFromDb);
            return resultModels;
        }

    }
}
