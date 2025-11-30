using FoodMartMongo.Dtos.CustomerDtos;

namespace FoodMartMongo.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(string customerıd);
        Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerId);
    }
}
