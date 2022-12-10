using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    //[Authorize]
	public class WriterController : Controller
	{
        WriterManager _writerManager = new WriterManager(new EFWriterRepository());
		public IActionResult Index()
		{
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

        [AllowAnonymous]
        public IActionResult WriterEditProfile()
        {
            var writerValues = _writerManager.GetById(1);
            return View(writerValues);
        }
    }
}
