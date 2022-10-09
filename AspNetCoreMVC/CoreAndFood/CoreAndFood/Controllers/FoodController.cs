using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository _foodRepository = new FoodRepository();
        Context _context = new Context();
        public IActionResult Index(int page = 1)
        {
            return View(_foodRepository.TList("Category").ToPagedList(page, 3));
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
        public IActionResult FoodAdd(urunekle p)
        {
            Food f = new Food();
            if (p.ImageURL != null)
            {
                var extension = Path.GetExtension(p.ImageURL.FileName);
                var newimageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/resimler/", newimageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageURL.CopyTo(stream);
                f.ImageURL = newimageName;

            }

            f.Name = p.Name;
            f.Price = p.Price;
            f.Stock = p.Stock;
            f.CategoryID = p.CategoryID;
            f.Description = p.Description;
            _foodRepository.TAdd(f);
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
