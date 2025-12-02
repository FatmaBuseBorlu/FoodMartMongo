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
            if (!string.IsNullOrEmpty(Email))
            {
                await _mailService.SendDiscountCodeAsync(Email);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}