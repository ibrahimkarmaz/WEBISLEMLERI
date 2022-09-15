using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstPro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 34;
        }
        public string Index4()
        {
            return "Merhaba Bugün Hava Ortalama Derecede";
        }
        public IActionResult Index5()
        {
            var Kitaplar = new List<Kitap>()
            {
                new Kitap{ID=1,KitapAd="Kuyucaklı Yusuf",Yazar="Sebattin Ali"},
                new Kitap{ID=2,KitapAd="80 Günde Deveri Alem",Yazar="Jules Verne"},
                new Kitap{ID=3,KitapAd="Bilinmeyen bir kadının mektubu",Yazar="Zweig"},
                new Kitap{ID=4,KitapAd="Şeker Portakalı",Yazar="Vasconceulos"}
            };
            return View(Kitaplar);
        }

        public IActionResult Index6()
        {
            ViewBag.Deger1 = "Merhaba ViewBag";
            return View();
        }

        public IActionResult Index7()
        {
            return View();
        }

        public IActionResult Index8()
        {
            return View();
        }

        public IActionResult Index9()
        {
            return View();
        }
    }
}