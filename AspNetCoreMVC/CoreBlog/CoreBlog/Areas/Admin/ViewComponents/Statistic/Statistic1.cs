using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
        Context _context = new Context();
        public IViewComponentResult Invoke()
        { 
            ViewBag.v1 = _blogManager.GetList().Count;
            ViewBag.v2 = _context.Contacts.Count();
            ViewBag.v3 = _context.Comments.Count();
            return View();
        }
    }
}
