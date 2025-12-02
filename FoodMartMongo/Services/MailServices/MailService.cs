using FoodMartMongo.Services.MailServices;
using MailKit.Net.Smtp;
using MimeKit;

namespace FoodMart.Services.MailServices
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendDiscountCodeAsync(string toEmail)
        {
            string discountCode = "FOOD" + new Random().Next(1000, 9999);

            var mimeMessage = new MimeMessage();
            var mailboxAddressFrom = new MailboxAddress(
                _configuration["MailSettings:DisplayName"],
                _configuration["MailSettings:Mail"]);

            var mailboxAddressTo = new MailboxAddress("User", toEmail);

            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);
            mimeMessage.Subject = "Hoşgeldiniz! İndirim Kodunuz Burada 🎉";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $@"
                <div style='font-family: Arial, sans-serif; padding: 20px; border: 1px solid #eee;'>
                    <h2 style='color: #ffc107;'>FoodMart Ailesine Hoşgeldiniz!</h2>
                    <p>Bültenimize abone olduğunuz için teşekkür ederiz.</p>
                    <p>İlk alışverişinizde geçerli <strong>%25 İndirim</strong> kodunuz:</p>
                    <h1 style='background-color: #f8f9fa; padding: 10px; display: inline-block; letter-spacing: 5px;'>{discountCode}</h1>
                    <p>Keyifli alışverişler dileriz.<br>FoodMart Ekibi</p>
                </div>";

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration["MailSettings:Host"], int.Parse(_configuration["MailSettings:Port"]), false);

                await client.AuthenticateAsync(_configuration["MailSettings:Mail"], _configuration["MailSettings:Password"]);

                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}