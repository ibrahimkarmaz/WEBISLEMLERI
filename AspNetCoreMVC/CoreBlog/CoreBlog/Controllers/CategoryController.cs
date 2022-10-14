using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = _categoryManager.GetList();
            return View(values);
        }
    }
}
