using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
