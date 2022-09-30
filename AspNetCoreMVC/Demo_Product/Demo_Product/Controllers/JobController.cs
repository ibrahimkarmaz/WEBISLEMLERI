using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
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
        public IActionResult AddJob(Job job)
        {

            _jobManager.TInsert(job);
                return RedirectToAction("Index");
        }

        public IActionResult DeleteJob(int id)
        {
            var value = _jobManager.TGetById(id);
            _jobManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = _jobManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            _jobManager.TUpdate(job);
            return RedirectToAction("Index");
        }
    }
}
