using System.Buffers.Text;
using AutoMapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace FoodConsluting.Repositories
{
    public interface IBaseRepository<TEntity> 
    {
        TEntity GetOne(int id);

        List<TEntity> GetAll();        
    }

    public class BaseRepository<TEntity>  
    {
        private readonly IConfiguration configuration;
        public string connectionString;
        public MySqlConnection connection;

        public BaseRepository(IConfiguration configuration){
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            connection = new MySqlConnection(connectionString);

        }        

        /*
        public TEntity GetOne(int id){

        }
        */
    }
}