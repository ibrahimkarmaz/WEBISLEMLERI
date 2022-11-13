using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager _newsletterManager = new NewsLetterManager(new EFNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            ViewData["Data"] = new NewsLetter();
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            _newsletterManager.AddNewsLetter(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
