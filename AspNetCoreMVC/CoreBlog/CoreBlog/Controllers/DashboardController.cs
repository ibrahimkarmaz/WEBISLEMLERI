using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context _context = new Context();
            ViewBag.v1 = _context.Blogs.Count().ToString();
            ViewBag.v2 = _context.Blogs.Where(x => x.WriterID == 1).Count();
            ViewBag.v3 = _context.Categories.Count().ToString();
            return View();
        }
    }
}
