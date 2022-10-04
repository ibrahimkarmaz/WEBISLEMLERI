using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository _foodRepository = new FoodRepository();
        public IActionResult Index()
        {
            return View(_foodRepository.TList("Category"));
        }

        [HttpGet]
        public IActionResult FoodAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FoodAdd(Food food)
        {
            _foodRepository.TAdd(food);
            return RedirectToAction("Index");
        }
    }
}
