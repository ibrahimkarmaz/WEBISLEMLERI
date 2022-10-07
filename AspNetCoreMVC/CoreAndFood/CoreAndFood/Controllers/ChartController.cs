using CoreAndFood.Data;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()//URUN SONUÇLARINI GÖRSELLEŞTİR İSİM
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                proname = "Computer",
                stock = 150
            });
            cs.Add(new Class1()
            {
                proname = "LDC",
                stock = 75
            });
            cs.Add(new Class1()
            {
                proname = "SDD",
                stock = 220
            });
            return cs;
        }

        public IActionResult Statictics()
        { Context context = new Context();
            var deger1 = context.Foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = context.Categorys.Count();
            ViewBag.d2 = deger2;

            var deger3 = context.Foods.Where(x => x.CategoryID == (context.Categorys.Where(a => a.CategoryName == "Fruit").First().CategoryID)).Count();
            ViewBag.d3 = deger3;

            var deger4 = context.Foods.Count(x => x.CategoryID == (context.Categorys.Where(a => a.CategoryName == "Vegetables").First().CategoryID));
            ViewBag.d4 = deger4;

            var deger5 = context.Foods.Sum(x => x.Stock);
            ViewBag.d5 = deger5;

            var deger6 = context.Foods.Count(x => x.CategoryID == (context.Categorys.Where(a => a.CategoryName.ToLower() == "Lagumes".ToLower()).First().CategoryID));
            ViewBag.d6 = deger6;

            var deger7 = context.Foods.OrderByDescending(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = context.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = context.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = deger9;





            return View();
        }
        [AllowAnonymous]
        public IActionResult Index5()
        {
            FoodRepository _foodRepository = new FoodRepository();
           var values=_foodRepository.TList();
            return View(values);
        }

    }
}
