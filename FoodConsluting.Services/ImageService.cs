using AutoMapper;
using FoodConsluting.Data;
using FoodConsulting.Repositories;

namespace FoodConsluting.Services
{
    public interface IImageService
    {
        List<Image> GetImages();

        Image GetImageById(int id);
    }

    public class ImageService : IImageService
    {
        private readonly IImageRepository repository;

        private readonly IMapper mapper;

        public ImageService(IImageRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<Image> GetImages()
        {
            var resultFromDb = repository.GetAll();
            var result = mapper.Map<List<Image>>(resultFromDb);
            return result;
        }

        public Image GetImageById(int id)
        {
            var resultFromDb = repository.GetOne(id);
            var result = mapper.Map<Image>(resultFromDb);
            return result;
        }

    }
}