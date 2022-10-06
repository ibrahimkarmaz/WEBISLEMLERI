using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        FoodRepository foodRepository = new FoodRepository();
        public IViewComponentResult Invoke()
        {
            var foodlist = foodRepository.TList();
            return View(foodlist);
        }
    }
}
