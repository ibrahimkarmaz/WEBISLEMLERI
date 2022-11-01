using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
       public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
