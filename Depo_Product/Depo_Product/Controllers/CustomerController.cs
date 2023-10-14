using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Depo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
        public IActionResult Index()
        {
            var values = _customerManager.GetCustomerAndJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            JobManager jobManager = new JobManager(new EFJobDAL());
            List<SelectListItem> values=(from x in jobManager.TGetList()
                                         select new SelectListItem
                                         {
                                             Text=x.JobName,
                                             Value=x.JobID.ToString()
                                         }).ToList();
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            _customerManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id)
        {
            var values = _customerManager.GetById(id);
            _customerManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var values = _customerManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            _customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
