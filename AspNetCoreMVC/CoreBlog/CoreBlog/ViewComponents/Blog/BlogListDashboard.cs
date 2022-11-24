using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogListWithCategory().OrderByDescending(x=>x.BlogID).Take(10).ToList();
            return View(values);
        }
    }
}
