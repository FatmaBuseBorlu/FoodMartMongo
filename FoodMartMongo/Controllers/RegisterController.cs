using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
