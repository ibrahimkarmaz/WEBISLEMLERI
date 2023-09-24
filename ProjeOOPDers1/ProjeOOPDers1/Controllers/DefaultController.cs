using Microsoft.AspNetCore.Mvc;
using ProjeOOPDers1.Examples;
using System;

namespace ProjeOOPDers1.Controllers
{
	public class DefaultController : Controller
	{//METODLAR VE ERİŞİM BELİRLEYİCİLER
		/*EĞER DEĞİŞKENLERİLE İŞLEM YAPILMASI GEREKİYORSA METOD İÇİNDE YAPILMALI.
		 * 
		 * int sayi;
		int sayi2;
		int toplam = sayi + sayi2;*/
		/*void Process()
		{
			ExampleClass1 _exampleClass1 = new ExampleClass1();
			_exampleClass1.Sum();

		}*/
		int Sum()
		{
			int s1 = 20;
			int s2 = 30;
			int total = s1+s2;
			return total;
		}
		void Mesajlar()
		{
			ViewBag.m1 = "Bu bir core projesidir";
			ViewBag.m2 = "Bu bir core projesidir2";
		}

		public IActionResult Index()
		{
			Mesajlar();
			return View();
		}

		public IActionResult ProductView()
		{
            Mesajlar();
			ViewBag.total = Sum();
            return View();
		}

		public IActionResult TryOne()
		{
			Countys countys = new Countys();
			countys.Name = "Kiew";
			countys.Id = 1;
			countys.Population = 423423432;
			countys.County = "Ukrain";
			return View();
		}
	}
}
