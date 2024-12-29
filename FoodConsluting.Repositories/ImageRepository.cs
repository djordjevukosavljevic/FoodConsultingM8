using FoodConsluting.Repositories;
using FoodConsluting.Data;
using Microsoft.Extensions.Configuration;

namespace FoodConsulting.Repositories
{
    public interface IImageRepository : IBaseRepository<Image>
    {

    }

    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}