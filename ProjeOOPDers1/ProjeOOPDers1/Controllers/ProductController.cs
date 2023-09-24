using Microsoft.AspNetCore.Mvc;
using ProjeOOPDers1.Context;
using ProjeOOPDers1.Entity;
using System;
using System.Linq;

namespace ProjeOOPDers1.Controllers
{
	public class ProductController : Controller
	{
		Context.Context _context = new Context.Context();
		public IActionResult Index()
		{
			var values = _context.Products.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddProduct()
		{
			Console.Write("DASDASDAS");
            return View();
		}

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            _context.Products.Add(p);
			_context.SaveChanges();
			return RedirectToAction("Index");
        } 

        public IActionResult DeleteProduct(int id)
        {
			var value = _context.Products.Where(x => x.Id == id).FirstOrDefault();
			_context.Remove(value);
			_context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id )
        {
            var values = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var urun = _context.Products.Where(x => x.Id == p.Id).FirstOrDefault();
            urun.Id = p.Id;
            urun.Name = p.Name;
            urun.Price = p.Price;
            urun.Stock = p.Stock;

           // _context.Products.Update(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
