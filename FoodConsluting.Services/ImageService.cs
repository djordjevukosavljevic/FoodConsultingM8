using FoodConsluting.Data;
using Microsoft.Extensions.Configuration;

namespace FoodConsluting.Repositories
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