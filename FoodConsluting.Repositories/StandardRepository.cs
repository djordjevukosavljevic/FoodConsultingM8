using FoodConsluting.Data;
using Microsoft.Extensions.Configuration;


namespace FoodConsluting.Repositories
{
    public interface IStandardRepository : IBaseRepository<Standard>
    {

    }

    public class StandardRepository : BaseRepository<Standard>, IStandardRepository
    {
        public StandardRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
