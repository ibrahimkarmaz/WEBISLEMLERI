using BusinessLayer.Concrete;
using BusinessLayer.ValidatonRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult result = writerValidator.Validate(writer);
            if (result.IsValid)
            {
                writer.WriteStatus = true;
                writer.WriterAbout = "Deneme Test";
                _writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(writer);//EĞER HATA VAR İSE YİNE AYNI PENCERE AÇILIR FAKAT WRİTER ALINAN BİLGİYİ GERİ DÖNDÜRÜR.
        }
    }
}
