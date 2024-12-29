// using FoodConsluting.Data;
using System.Buffers.Text;
using AutoMapper;
using Dapper;
using FoodConsluting.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;


namespace FoodConsluting.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetOne(int id);
    }

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Base
    {
        private readonly IConfiguration configuration;
        public string connectionString;
        public MySqlConnection connection;

        public BaseRepository(IConfiguration configuration)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            connection = new MySqlConnection(connectionString);

        }

        public List<TEntity> GetAll()
        {
            var result = connection.GetList<TEntity>().ToList();
            return result;

        }

        public TEntity GetOne(int id)
        {
            var result = connection.Get<TEntity>(id);
            return result;
        }


    }
}