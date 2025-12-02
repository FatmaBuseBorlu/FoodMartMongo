namespace FoodMartMongo.Services.MailServices
{
    public interface IMailService
    {
        Task SendDiscountCodeAsync(string toEmail);
    }
}
