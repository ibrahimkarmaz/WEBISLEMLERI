using Microsoft.AspNetCore.Mvc;
using OopDers1.Entity;
using OopDers1.ProjeContext;
using System.Linq;
using System.Security.Cryptography;

namespace OopDers1.Controllers
{
    public class CustomerController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var values = _context.customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value=_context.customers.Find(id);
            _context.Remove(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = _context.customers.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var value = _context.customers.Find(customer.ID);
            value.City = customer.City;
            value.Name = customer.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
