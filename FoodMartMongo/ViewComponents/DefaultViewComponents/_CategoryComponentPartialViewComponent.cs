using FoodMartMongo.Services.CategoryServices; 
using Microsoft.AspNetCore.Mvc;

namespace FoodMart.ViewComponents.DefaultViewComponents
{
    public class _CategoryComponentPartialViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _CategoryComponentPartialViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}