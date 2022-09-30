using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
        JobManager _jobManager = new JobManager(new EFJobDAL());
        public IActionResult Index()
        {
            var values = _customerManager.GetCustomersListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {//Linq Hatası için üstüne gelip; using System.Linq; eklenmeli.

            JobSelectListItemGet();//Metod
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerManager.TInsert(customer);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value=_customerManager.TGetById(id);
            _customerManager.TDelete(value);
           return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = _customerManager.TGetById(id);
            JobSelectListItemGet();//Metod
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }

        //BURASI 2'DEN FAZLA KULLANILDIĞI İÇİN TEK METOD İÇİNE ALDIM
        private void JobSelectListItemGet()
        {
            List<SelectListItem> values = (from x in _jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();

            ViewBag.v = values;
        }

    }
}
