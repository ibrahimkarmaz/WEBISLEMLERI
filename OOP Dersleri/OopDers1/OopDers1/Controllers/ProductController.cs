using Microsoft.AspNetCore.Mvc;
using OopDers1.Entity;
using OopDers1.ProjeContext;
using System.Linq;

namespace OopDers1.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            context.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
           var value= context.products.Find(id);
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePruduct(int id)
        {
            var value = context.products.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePruduct(Product product)
        {
            var value = context.products.Find(product.ID);
            value.Name= product.Name;
            value.Price = product.Price;
            value.Stock = product.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
