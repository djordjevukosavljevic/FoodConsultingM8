

using FoodConsluting.Data;

namespace FoodConsluting.Services
{
    public interface IStandardService
    {
        public Standard GetById(int id);
    }

    public class StandardService : IStandardService
    {
        public Standard GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
