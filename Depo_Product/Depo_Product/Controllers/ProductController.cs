using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Depo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        public IActionResult Index()
        {
            var values = _productManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            _productManager.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
