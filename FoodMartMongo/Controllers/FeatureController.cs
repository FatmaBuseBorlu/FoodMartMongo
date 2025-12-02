using FoodMartMongo.Dtos.FeatureDtos;
using FoodMartMongo.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMart.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        // Listeleme Sayfası (Eklediklerimizi görmek için)
        public async Task<IActionResult> Index()
        {
            var values = await _featureService.GetAllFeatureAsync();
            return View(values);
        }

        // Ekleme Sayfası (Veri girmek için)
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            await _featureService.CreateFeatureAsync(createFeatureDto);
            return RedirectToAction("Index");
        }

        // Silme İşlemi
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _featureService.DeleteFeatureAsync(id);
            return RedirectToAction("Index");
        }
    }
}