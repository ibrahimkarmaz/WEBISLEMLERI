using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Depo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager _jobManager = new JobManager(new EFJobDAL());
        public IActionResult Index()
        {
            var values = _jobManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            JobValidator validationRules = new JobValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _jobManager.TAdd(p);
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

        public IActionResult DeleteJob(int id)
        {
            var values = _jobManager.GetById(id);
            _jobManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var values = _jobManager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            _jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
