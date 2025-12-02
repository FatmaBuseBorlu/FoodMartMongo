using FoodMart.Services.MailServices;
using FoodMartMongo.Services.MailServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMart.Controllers
{
    public class MailController : Controller
    {
        private readonly IMailService _mailService;

        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return Content("Hata: Email adresi boş geldi! HTML'deki name='Email' kısmını kontrol et.");
            }

            try
            {
                await _mailService.SendDiscountCodeAsync(Email);
                return Content("Başarılı! Mail gönderildi. Spam kutunu kontrol et.");
            }
            catch (Exception ex)
            {
                return Content("Mail Gönderme Hatası: " + ex.Message);
            }
        }
    }
}