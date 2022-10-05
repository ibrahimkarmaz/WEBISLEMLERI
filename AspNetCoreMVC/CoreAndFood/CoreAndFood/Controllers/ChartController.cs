using CoreAndFood.Data;
using CoreAndFood.Data.Models;
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
        {
            return View();
        }
    }
}
