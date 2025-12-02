using Microsoft.AspNetCore.Mvc;
using FoodMartMongo.Services.FeatureServices; 

namespace FoodMartMongo.ViewComponents.DefaultViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;
        public _FeatureComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllFeatureAsync();
            return View(values);
        }
    }
}