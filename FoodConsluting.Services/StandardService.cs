

using FoodConsluting.Data;
using Microsoft.EntityFrameworkCore;

namespace FoodConsluting.Services 
{
    public interface IStandardService 
    {
        public Standard GetById(int id);
    
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
