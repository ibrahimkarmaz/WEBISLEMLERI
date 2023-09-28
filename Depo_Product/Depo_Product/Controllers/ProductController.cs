using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

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
            ProductValidator validationRules = new ProductValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _productManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            var values = _productManager.GetById(id);
            _productManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _productManager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            _productManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
