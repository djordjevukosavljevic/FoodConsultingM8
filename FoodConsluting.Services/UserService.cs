using AutoMapper;
using FoodConsluting.Data;
using FoodConsluting.Repositories;
namespace FoodConsluting.Services
{
    public interface IUserService{
        User GetUser(string username);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        private readonly IMapper mapper;

        public User UserService(IUserRepository userRepository, IMapper mapper){
            this.mapper = mapper;
        } 

        public User GetUser(string username)
        {
                throw new NotImplementedException();
        }
        


    }
}