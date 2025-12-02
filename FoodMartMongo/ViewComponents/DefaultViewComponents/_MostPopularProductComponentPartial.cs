using FoodMartMongo.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMart.ViewComponents.DefaultViewComponents
{
    public class _MostPopularProductComponentPartialViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _MostPopularProductComponentPartialViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}