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
            // 1. İndirim Kodu Oluştur
            string discountCode = "FOOD" + new Random().Next(1000, 9999);

            // 2. Mail İçeriğini Hazırla
            var mimeMessage = new MimeMessage();

            // Gönderen Bilgisi
            var mailboxAddressFrom = new MailboxAddress(
                _configuration["MailSettings:DisplayName"],
                _configuration["MailSettings:Mail"]);

            // Alıcı Bilgisi
            var mailboxAddressTo = new MailboxAddress("User", toEmail);

            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);

            // Konu
            mimeMessage.Subject = "Hoşgeldiniz! İndirim Kodunuz Burada 🎉";

            // Mesaj Gövdesi (HTML)
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

            // 3. Gönderme İşlemi (SMTP)
            using (var client = new SmtpClient())
            {
                // SSL ayarı false yapıyoruz çünkü StartTls kullanacağız (587 portu için)
                await client.ConnectAsync(_configuration["MailSettings:Host"], int.Parse(_configuration["MailSettings:Port"]), false);

                await client.AuthenticateAsync(_configuration["MailSettings:Mail"], _configuration["MailSettings:Password"]);

                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}