using FoodConsluting.Data;
namespace FoodConsluting.Repositories{
    public interface IUserRepository : IBaseRepository<User>
    {

    } 

    public class UserRepository  : UserRepositoryBase<User>, IUserRepository
    {


    }
}