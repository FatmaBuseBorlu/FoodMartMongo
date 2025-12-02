using FoodMartMongo.Dtos.SliderDtos;

namespace FoodMartMongo.Services.DiscountServices
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountDto>> GetAllDiscountAsync();
        Task CreateDiscountAsync(CreateDiscountDto createDiscountDto);
        Task UpdateDiscountAsync(UpdateDiscountDto updateDiscountDto);
        Task DeleteDiscountAsync(string id);
        Task<GetDiscountByIdDto> GetDiscountByIdAsync(string id);
    }
}
