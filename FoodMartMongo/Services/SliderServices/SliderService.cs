using AutoMapper;
using FoodMartMongo.Dtos.SliderDtos;
using FoodMartMongo.Entities;
using FoodMartMongo.Settings;
using MongoDB.Driver;

namespace FoodMartMongo.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMongoCollection<Slider> _sliderCollection;
        private readonly IMapper _mapper;

        public SliderService(IDatabaseSettings _databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }
        public Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSliderAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetSliderByIdDto> GetSliderByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            throw new NotImplementedException();
        }
    }
}
