using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CoreAndFood.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            FoodRepository food = new FoodRepository();
            var foodlist = food.List(x=>x.CategoryID==id);
            return View(foodlist);
        }
    }
}
