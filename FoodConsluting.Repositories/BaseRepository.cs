using System.Buffers.Text;

namespace FoodConsluting.Repositories
{
    public interface IBaseRepository<TEntity> // where TEntity : Base
    {
        TEntity GetOne(int id);
    }

/*
    public class BaseRepo BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Base
    {
        private readonly IConfiguration configuration;

        public string coonectionString;

        public MySqlConnection connection;

        public BaseRepository(IConfiguration configuration){
            
        }
    }
    */
}