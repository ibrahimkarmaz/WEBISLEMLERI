using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository _foodRepository = new FoodRepository();
        Context _context = new Context();
        public IActionResult Index(int page=1)
        {
            return View(_foodRepository.TList("Category").ToPagedList(page,3));
        }

        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> values = (from x in _context.Categorys.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult FoodAdd(Food food)
        {
            _foodRepository.TAdd(food);
            return RedirectToAction("Index");
        }

        public IActionResult FoodDelete(int id)
        {
            var value = _foodRepository.TGet(id);
            _foodRepository.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FoodUpdate(int id)
        {
            List<SelectListItem> values = (from x in _context.Categorys.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            var value = _foodRepository.TGet(id);    
            return View(value);
        }


        [HttpPost]
        public IActionResult FoodUpdate(Food food)
        {
            _foodRepository.TUpdate(food);
            return RedirectToAction("Index");
        }
    }
}
