

using FoodConsluting.Data;
using Microsoft.EntityFrameworkCore;

namespace FoodConsluting.Services 
{
    public interface IStandardService  
    {
        
    
        public List<Standard> GetAll();
    }

    public class StandardService : IStandardService
    {
        public List<Standard> GetAll()
        {
            throw new Exception("Bug");
        }
    }
}
