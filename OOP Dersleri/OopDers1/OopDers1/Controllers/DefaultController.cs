using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using OopDers1.Ornekler;
using System.Collections.Generic;

namespace OopDers1.Controllers
{
    public class DefaultController : Controller
    {
        /*void Islemler()
         {
             Class c = new Class();
             c.Topla();
         }*/
        void Messages()
        {
            ViewBag.m1 = "Merhaba Bu bir Core Projesi";
            ViewBag.m2 = "Merhaba Proje çok iyi duruyor.";
            ViewBag.m3 = "Selamlar Hello Hi Borjour";
        }

        int Topla()
        {
            int s1 = 20, s2 = 30;
            return s1 + s2;
        }
        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            return 2 * (kisa + uzun);
        }
        public IActionResult Index()
        {
            Messages();
            return View();
        }

        //1'den başlayarak belirli bir sayma sayısına kadar olan sayıların çarpımına o sayının faktöriyeli denir.
        int FaktoriyelVersiyon1()
        {
            int sayac = 1, N = 10, faktorilyel = 1;
            while (sayac <= N)
            {
                faktorilyel *= sayac;
                sayac++;
            }
            return faktorilyel;
        }

        int FaktoriyelVersiyon2()
        {
            int faktorilyel = 1;
            for (int i = 1; i <= 10; i++)
            {
                faktorilyel *= i;
            }
            return faktorilyel;
        }

        int FaktoriyelVersiyon3()
        {
            int sayac = 10, N = 1, faktorilyel = 1;
            do
            {
                faktorilyel *= sayac;
                sayac--;
            } while (sayac >= N);

            return faktorilyel;
        }

        public IActionResult Urunler()
        {
            Messages();
            ViewBag.t = Topla();
            ViewBag.c = Cevre();
            ViewBag.Faktoriyel = FaktoriyelVersiyon1();
            ViewBag.Faktoriye2 = FaktoriyelVersiyon2();
            ViewBag.Faktoriye3 = FaktoriyelVersiyon3();
            // ViewBag.Faktoriye4=FaktoriyelVersiyon1();
            return View();
        }
        private string Cumle()
        {
            return "Merhaba Cumle Kuruldu.";
        }

        public IActionResult Musteriler()
        {
            ViewBag.cumle = Cumle();
            MesajListesi("Merhaba");
            Kullanici("İbrahim");
            return View();
        }


        private void MesajListesi(string p)
        {
            ViewBag.v = p;
        }
        private void Kullanici(string UserName = "")
        {
            ViewBag.isim = "Hoşgeldiniz " + UserName.ToString();
        }

        public IActionResult Deneme()
        {
            var gonder = new List<Sehirler>
            {
                new Sehirler{ID=1,SehirAd="Kiev",Ulke="Ukranya",Nufus=350000,Renk1="Mavi",Renk2="Sari",Renk3="Yok"}
            };

            return View(gonder);
        }
    }
}
