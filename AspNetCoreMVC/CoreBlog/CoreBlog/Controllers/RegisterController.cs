using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            //34'den devam et.
        }
    }
}
