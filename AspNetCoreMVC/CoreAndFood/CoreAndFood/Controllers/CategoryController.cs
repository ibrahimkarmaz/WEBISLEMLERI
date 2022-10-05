using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public IActionResult Index()
        {
            return View(_categoryRepository.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            _categoryRepository.TAdd(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var value = _categoryRepository.TGet(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            _categoryRepository.TUpdate(category);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var value = _categoryRepository.TGet(id);
            value.Status = false;
            _categoryRepository.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
