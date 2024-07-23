

using FoodConsluting.Data;
using Microsoft.EntityFrameworkCore;

namespace FoodConsluting.Services 
{
    public interface IStandardService 
    {
        // private readonly IStandardRepository standardRepository;
    
        public List<Standard> GetAll();
    }

    public class StandardService : IStandardService
    {


        public Standard GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<Standard> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
