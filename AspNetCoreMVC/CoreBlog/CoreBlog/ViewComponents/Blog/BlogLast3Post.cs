using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetLast3Blog();
            return View(values);
        }
    }
}
