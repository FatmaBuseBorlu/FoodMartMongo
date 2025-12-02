using FoodMartMongo.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMart.ViewComponents.DefaultViewComponents
{
    public class _BestSellerProductComponentPartialViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _BestSellerProductComponentPartialViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetCheapestProductsAsync();
            return View(values);
        }
    }
}