using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            return View();
        }
    }
}
