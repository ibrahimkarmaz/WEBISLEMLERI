using BusinessLayer.Concrete;
using BusinessLayer.ValidatonRules;
using CoreBlog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.IO;
using System.Linq;

namespace CoreBlog.Controllers
{
    [Authorize]
	public class WriterController : Controller
	{
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());
		public IActionResult Index()
		{
            var UserMail = User.Identity.Name;
            ViewBag.v = UserMail;
			return View();
		}

        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

       
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            Context _context = new Context();
            var userMail = User.Identity.Name;
            var WriterID = _context.Writers.Where(x => x.WriterMail == userMail).FirstOrDefault().WriterID;
            var writerValues = _writerManager.GetById(WriterID);
            return View(writerValues);
        }

       
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult result = wl.Validate(p);
            if (result.IsValid)
            {
                _writerManager.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriteImage!=null)
            {
                var extension = Path.GetExtension(p.WriteImage.FileName);//Eklenen Resim adını aldık
                var newImageName = Guid.NewGuid() + extension;//Resmin önüne rasgele sayı ekledik ve ismini sonuna ekledik
                var lacation = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);//Yolu belirledik
                var stream = new FileStream(lacation, FileMode.Create);//Dosyayı belirlenen yola oluşturduk.
                p.WriteImage.CopyTo(stream);//Dosyayı Yola Kopyaladık.
                w.WriteImage = newImageName;//Entityleri değiştirdik.
            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriteStatus = true;
            w.WriterAbout = p.WriterAbout;
            _writerManager.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
